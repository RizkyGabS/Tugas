using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas
{
    public partial class FrmCalculator : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Hasil hsl);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa
        private Hasil hsl;
        public FrmCalculator()
        {
            InitializeComponent();
        }


        // Constructor untuk inisialisasi data ketika entri data baru
        public FrmCalculator(string title)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
        }
        // Constructor untuk inisialisasi data ketika mengedit data
        public FrmCalculator(string title, Hasil obj)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            isNewData = false; // set status edit data
            hsl = obj; // set objek mhs yang akan diedit
                       // untuk edit data, tampilkan data lama
            txtNilaiA.Text = hsl.NilaiA;
            txtNilaiB.Text = hsl.NilaiB;
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            
            // jika data baru, inisialisasi objek Hasil
            if (isNewData) hsl = new Hasil();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            hsl.NilaiA = txtNilaiA.Text;
            hsl.NilaiB = txtNilaiB.Text;
            if (isNewData) // data baru
            {
                OnCreate(hsl); // panggil event OnCreate
                               // reset form input, utk persiapan input data berikutnya
                txtNilaiA.Clear();
                txtNilaiB.Clear();
                txtNilaiA.Focus();
            }
            else // update
            {
                OnUpdate(hsl); // panggil event OnUpdate
                this.Close();
            }
        }
    }
}
