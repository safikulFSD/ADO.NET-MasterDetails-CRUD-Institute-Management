using ADO_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Project
{
    public partial class Form1 : Form
    {
        int inTeachId = 0;
        bool isDefaultImage =true;
        string strConnectionString = @"Data Source=DESKTOP-RN0S836;database=teacherDB;Integrated Security=True", strPreviousImage = " " ;
        OpenFileDialog ofd = new OpenFileDialog();  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtTechCode.Text = txtTechName.Text = "";
            cmbPositon.SelectedIndex = cmbGender.SelectedIndex = 0;
            dtpDOB.Value = DateTime.Now;
            rbtRegular.Checked = true;
            if (dgvTechInstitute.DataSource == null)
                dgvTechInstitute.Rows.Clear();
            inTeachId = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            pbxPhoto.Image = Image.FromFile(Application.StartupPath + "\\Images\\defaultImage.png");
            isDefaultImage = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTeacherDataGridView();
            PositionComboBoxFill();
            Clear();
        }
        void PositionComboBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Position", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);
                DataRow topItem = dtb1.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtb1.Rows.InsertAt(topItem, 0);
                cmbPositon.ValueMember = dgvcmbPosition.ValueMember = "PositionId";
                cmbPositon.DisplayMember = dgvcmbPosition.DisplayMember = "Position";
                cmbPositon.DataSource = dtb1;
                dgvcmbPosition.DataSource = dtb1.Copy();
            }
        }

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.png,.png)|*.png;*.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = new Bitmap(ofd.FileName);
                isDefaultImage = false;
                strPreviousImage = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateMasterDetailForm())
            {
                int _TeachId = 0;
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    //Master
                    SqlCommand sqlCmd = new SqlCommand("TeacherAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@TeachId", inTeachId);
                    sqlCmd.Parameters.AddWithValue("@TeachCode", txtTechCode.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@TeachName", txtTechName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PositionId", Convert.ToInt32(cmbPositon.SelectedValue));
                    sqlCmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                    sqlCmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    sqlCmd.Parameters.AddWithValue("@State", rbtRegular.Checked ? "Regular" : "Contractual");
                    if(isDefaultImage)
                        sqlCmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    else if (inTeachId > 0 && strPreviousImage !="")
                        sqlCmd.Parameters.AddWithValue("@ImagePath", strPreviousImage);
                    else
                        sqlCmd.Parameters.AddWithValue("@ImagePath", SaveImage(ofd.FileName));
                    _TeachId = Convert.ToInt32(sqlCmd.ExecuteScalar());
                }
                //Details
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    foreach (DataGridViewRow dgvRow in dgvTechInstitute.Rows)
                    {
                        if (dgvRow.IsNewRow) break;
                        else
                        {
                            SqlCommand sqlCmd = new SqlCommand("TechInstituteAddOrEdit", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@TechInstId", Convert.ToInt32(dgvRow.Cells["dgvtxtTeachInstId"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtTeachInstId"].Value));
                            sqlCmd.Parameters.AddWithValue("@TeachId", _TeachId);
                            sqlCmd.Parameters.AddWithValue("@InstName", dgvRow.Cells["dgvtxtInstName"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtInstName"].Value);
                            sqlCmd.Parameters.AddWithValue("@positionId", Convert.ToInt32(dgvRow.Cells["dgvcmbPosition"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbPosition"].Value));
                            sqlCmd.Parameters.AddWithValue("@ExpYear", Convert.ToInt32(dgvRow.Cells["dgvtxtYear"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtYear"].Value));
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                }
                FillTeacherDataGridView();
                Clear();
                MessageBox.Show("Subblited SuccessFully");
            }
        }
        bool ValidateMasterDetailForm()
        {
            bool _isValid = true;
            if (txtTechName.Text.Trim() == "")
            {
                MessageBox.Show("Teacher Name is required");
                _isValid = false;
            }
            return _isValid;
        }
        string SaveImage(string _imagePath)
        {
            string _fileName = Path.GetFileNameWithoutExtension(_imagePath);
            string _extension = Path.GetExtension(_imagePath);

            //shorten image name
            _fileName = _fileName.Length <= 15 ? _fileName : _fileName.Substring(0, 15);
            _fileName = _fileName + DateTime.Now.Ticks + _extension;
            pbxPhoto.Image.Save(Application.StartupPath + "\\Images\\" + _fileName);
            return _fileName;
        }
        //string SaveImage(string _imagePath)
        //{
        //    string _fileName = Path.GetFileNameWithoutExtension(_imagePath);
        //    string _extension = Path.GetExtension(_imagePath);

        //    //shorten image name
        //    _fileName = _fileName.Length <=15 ? _fileName : _fileName.Substring(0,15);
        //    _fileName =_fileName +DateTime.Now.Ticks.ToString("yymmssfff" + _extension);
        //    pbxPhoto.Image.Save(Application.StartupPath + "\\Images\\" + _fileName);
        //    return _fileName;
        //}
        void FillTeacherDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("TeacherViewAll", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvTeacher.DataSource = dtbl;
                dgvTeacher.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTeacher.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvTeacher.Columns[0].Visible = false;
            }
        }

        private void dgvTeacher_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTeacher.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow = dgvTeacher.CurrentRow;
                inTeachId = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("TeacherViewByID", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@TeachId", inTeachId);
                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds);

                    //master
                    DataRow dr = ds.Tables[0].Rows[0];
                    txtTechCode.Text = dr["TeachCode"].ToString();
                    txtTechName.Text = dr["TeachName"].ToString();
                    cmbPositon.SelectedValue = Convert.ToInt32(dr["PositionId"].ToString());
                    dtpDOB.Value = Convert.ToDateTime(dr["DOB"].ToString());
                    cmbGender.Text = dr["Gender"].ToString();
                    if (dr["State"].ToString() == "Regular")
                        rbtRegular.Checked = true;
                    else
                        rbtCotractual.Checked = true;
                    if (dr["ImagePath"] == DBNull.Value)
                    {
                        pbxPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\defaultImage.png");
                        isDefaultImage = true;
                    }
                    else
                    {
                        pbxPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\" + dr["ImagePath"].ToString());
                        strPreviousImage = dr["ImagePath"].ToString();
                        isDefaultImage = false;
                    }
                    dgvTechInstitute.AutoGenerateColumns = false;
                    dgvTechInstitute.DataSource = ds.Tables[1];
                    btnDelete.Enabled = true;
                    btnSave.Text = "Update";
                    tabControl1.SelectedIndex = 0;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delete This Record?", "Master Details CRUD", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlcmd = new SqlCommand("TeacherDelete", sqlCon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@TeachId", inTeachId);
                    sqlcmd.ExecuteNonQuery();
                    Clear();
                    FillTeacherDataGridView();
                    MessageBox.Show("Deleted Successfully");
                };

            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmRipo frmRipo = new frmRipo();
            frmRipo.Show();
        }

        private void btnImageClear_Click(object sender, EventArgs e)
        {
            pbxPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\defaultImage.png");
            isDefaultImage = true;
            strPreviousImage = "";
        }
    }
}
