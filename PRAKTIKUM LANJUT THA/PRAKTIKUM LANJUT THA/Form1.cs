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
using MySql.Data.MySqlClient;

namespace PRAKTIKUM_LANJUT_THA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string connectionString;
        string sqlQuery;
        DataTable dtnation = new DataTable();
        DataTable dtteam = new DataTable();
        DataTable dtmanagerdetail = new DataTable();
        DataTable dtmanagerdetail1 = new DataTable();
        DataTable dtplayerlist = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=db_theo";
            sqlQuery = "select nationality_id nationid, nation nationality from nationality;";
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtnation);
            txtboxnationality.DataSource = dtnation;
            txtboxnationality.ValueMember = "nationid";
            txtboxnationality.DisplayMember = "nationality";
            sqlQuery = "select team_id,team_name from team;";
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteam);
            txtboxteamname.DataSource = dtteam;
            txtboxteamname.ValueMember = "team_id";
            txtboxteamname.DisplayMember = "team_name";
            cmbteamname.DataSource = dtteam;
            cmbteamname.ValueMember = "team_id";
            cmbteamname.DisplayMember = "team_name";
            cmbteamname1.DataSource = dtteam;
            cmbteamname1.ValueMember = "team_id";
            cmbteamname1.DisplayMember = "team_name";
        }

        private void aDDPLAYERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneladdplayer.Visible = true;
            paneleditmanager.Visible = false;
        }

        private void eDITMANAGERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneladdplayer.Visible = false;
            paneleditmanager.Visible = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            string command = $"insert into player values('{txtboxplayerid.Text}','{txtboxteamnumber.Text}','{txtboxnama.Text}','{txtboxnationality.SelectedValue.ToString()}','{txtboxpos.Text}','{txtboxheight.Text}','{txtboxweight.Text}','{dtp1.Value.ToString("yyyy/MM/dd")}','{txtboxteamname.SelectedValue.ToString()}','1','0')";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
            } catch (Exception ex)
            {
                MessageBox.Show(command,ex.Message);

            }
            finally
            {
                conn.Close();
            }
            

        }
        string x = "";
        private void cmbteamname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Name, Team Name, Birthdate, Nationality
            dtmanagerdetail.Clear();
            
            sqlQuery = $"select m.manager_id,m.manager_name,t.team_name,m.birthdate, m.nationality_id, m.working from manager m left join team t on m.manager_id = t.manager_id where t.team_id = '{cmbteamname.SelectedValue.ToString()}';";
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtmanagerdetail);
            x = dtmanagerdetail.Rows[0][0].ToString();
            dgvmanager1.DataSource = dtmanagerdetail;
            dtmanagerdetail1.Clear();
            sqlQuery = $"select m.manager_id,m.manager_name,m.birthdate, m.nationality_id, m.working from manager m  where m.working = '0';";
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtmanagerdetail1);
            dgvmanager2.DataSource = dtmanagerdetail1;


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string command = $"update team set manager_id = '{idbaru}' where team_id = '{cmbteamname.SelectedValue}';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(command, ex.Message);

            }
            finally
            {
                conn.Close();
            }
            command = $"update manager set working = '0' where manager_id = '{x}';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(command, ex.Message);

            }
            finally
            {
                conn.Close();
            }
            command = $"update manager set working = '1' where manager_id = '{idbaru}';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(command, ex.Message);

            }
            finally
            {
                conn.Close();
            }

        }
        string idbaru = "";
        private void dgvmanager2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idbaru = dtmanagerdetail1.Rows[e.RowIndex][0].ToString(); 
        }

        private void rEMOVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbteamname1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sqlQuery = $"select p.player_id,p.player_name,n.nation,p.playing_pos,p.team_number, p.height, p.weight, p.birthdate, p.status from player p,nationality n where p.team_id = '{cmbteamname1.SelectedValue.ToString()}' and n.nationality_id = p.nationality_id and p.status = '1';";
            conn = new MySqlConnection(connectionString);

            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtplayerlist);
            dgvteamlist.DataSource = dtplayerlist;
            dgvteamlist.Columns.Remove("player_id");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtplayerlist.Rows.Count < 11)
            {
                MessageBox.Show("KURANG DR 11");
            }
            else
            {
                string command = $"update player set status = '0' where player_id = '{idbaru2}';";
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand(command, conn);
                    reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(command, ex.Message);

                }
                finally
                {
                    conn.Close();
                }
                dtplayerlist.Clear();
                sqlQuery = $"select p.player_id,p.player_name,n.nation,p.playing_pos,p.team_number, p.height, p.weight, p.birthdate, p.status from player p,nationality n where p.team_id = '{cmbteamname1.SelectedValue.ToString()}' and n.nationality_id = p.nationality_id and p.status = '1';";
                conn = new MySqlConnection(connectionString);
                cmd = new MySqlCommand(sqlQuery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtplayerlist);
                dgvteamlist.DataSource = dtplayerlist;
            }
           
            
        }

        string idbaru2 = "";
        private void dgvteamlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idbaru2 = dtplayerlist.Rows[e.RowIndex][0].ToString();
        }
    }
}
