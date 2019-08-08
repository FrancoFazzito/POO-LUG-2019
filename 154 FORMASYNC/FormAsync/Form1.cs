using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAsync
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<WebSite> listaDownload = AsyncClass.DownloadWebSync();
            AddListbox(listaDownload);

        }

        private async void /*task == void pero en eventos es void*/ Button2_ClickAsync(object sender, EventArgs e)
        {
            List<WebSite> listaDownload = await AsyncClass.DownloadWebAsync();
            AddListbox(listaDownload);
        }

        private void AddListbox(IEnumerable<WebSite> listaDownload)
        {
            foreach (var items in listaDownload)
            {
                listBox1.Items.Add($"URL { items.WebsiteUrl} DATALENGHT {items.WebsiteData.Length}");

            }
        }
        //web site data model
        //private void Button3_Click(object sender, EventArgs e)
        //{
        //    var listaDownload = AsyncClass.DownloadWebParallelAsyncParallel();
        //    var listaResultados = listaDownload.Result.ToList();
        //    foreach (var item in listaResultados)
        //    {
        //        listBox1.Items.Add(item);
        //    }    
        //}

        

        private void Button5_Click(object sender, EventArgs e)
        {
            var listaDownload = AsyncClass.DownloadWebParallel();
            AddListbox(listaDownload);
        }
    }
}
