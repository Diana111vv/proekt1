using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Linq;

namespace proekt1
{ 
    public partial class evaluationForm : Form 
    {

        SqlConnection sqlConnection=new SqlConnection("Server=wpl36.hosting.reg.ru;Database=u1615366_SQL_BASE;User Id=u1615366_SQL_BASE;Password=Bx8oe92%;");
        SqlCommand sqlCommand;
        int choosenAlp = -1;
        int currentAlp1 = 0;
        int currentAlp2 = 1;
        List<ImagePicture> pictures = new List<ImagePicture>();
        main main;

        public evaluationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public evaluationForm(main main)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.main = main;
        }

        private void pictures1_Click(object sender, EventArgs e)
        {
            Array array = null;
            sqlConnection.Open();
            for (int i = 1; i < 17; i++)
            {



                pictures1.Image = Image.FromFile(@$"{Environment.CurrentDirectory}\alpakas\{i}alp.jpg");
                MemoryStream ms = new MemoryStream();
                pictures1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                array = ms.ToArray();


                sqlCommand = new SqlCommand("INSERT INTO ImageTable (id,pictures1) VALUES (@Id,@pictures1)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Id", i);
                sqlCommand.Parameters.Add("@pictures1", SqlDbType.VarBinary, 8000).Value = array;
                sqlCommand.ExecuteNonQuery();
                array = null;
            }
            sqlConnection.Close();



        }

        private void evaluationForm_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand($"SELECT * FROM ImageTable", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            int i = 1;
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    byte[] data = (byte[])sqlDataReader.GetValue(1);
                    var stream = new MemoryStream(data);
                    pictures.Add(new ImagePicture(Image.FromStream(stream), i));
                    i++;

                }
            }
            sqlConnection.Close();
            int n = pictures.Count;
            Random r = new Random();
            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                ImagePicture value = pictures[k];
                pictures[k] = pictures[n];
                pictures[n] = value;
            }
            pictures1.Image = pictures[currentAlp1].image;
            picture2.Image = pictures[currentAlp2].image;
        }

        private void choose1_Click(object sender, EventArgs e)
        {
            choosenAlp = 1;
        }

        private void choose2_Click(object sender, EventArgs e)
        {
            choosenAlp = 2;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (choosenAlp == 1)
            {
                pictures[currentAlp1].rating++;
                ChangeAlpaco();

            }
            else if (choosenAlp == 2)
            {
                pictures[currentAlp2].rating++;
                ChangeAlpaco();
            }
            else
            {
                MessageBox.Show("Вы не выбрали альпаку");
            }
        }
        private void ChangeAlpaco()
        {
            if (currentAlp2 < 16)
            {
                if (currentAlp2 == 15 && currentAlp1 == 14)
                {
                    currentAlp1 = 0;

                }

                else
                {
                    currentAlp1++;
                    currentAlp2++;
                }
                if (currentAlp2 < 16 && currentAlp1 < 16)
                {
                    picture2.Image = pictures[currentAlp2].image;
                    pictures1.Image = pictures[currentAlp1].image;
                }
            }

            else
            {
                List<ImagePicture> winPictures = pictures.OrderBy(x => x.rating).ToList();
                main.pictureBoxWinner.Image = winPictures[0].image;
                Close();

            }


        }


    }
    
}
