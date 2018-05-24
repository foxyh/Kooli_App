using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kooli_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsefullLinks : ContentPage
    {
        public UsefullLinks()
        {
            InitializeComponent();
        }

        private void siseveebClick(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tpt.siseveeb.ee/"));
        }

        private void graafikClick(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/_layouts/15/guestaccess.aspx?docid=03802cc333b61440dbf02fb3b7bd46e66&authkey=AcMzCJyQuRyjlQR46BhqeYs"));
        }
        private void huviClick(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tptlive.ee/opilasele/huviringid/"));
        }
        private void toetusedClick(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tptlive.ee/oppetoo/oppekorralduseeskiri/"));
        }
        private void eeskordClick(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/_layouts/15/guestaccess.aspx?guestaccesstoken=0GQHb1buAehZFWPOP2qc4hZVDgeKBgB%2fhIrdg8w6RP0%3d&docid=0c329114c31c84b739172cfb0cb8eea52"));
        }
        private void vormistamineClick(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/_layouts/15/guestaccess.aspx?guestaccesstoken=CoiNNZnYM976%2bQw3YxQizeFGV34AoAJgArV31Bm6gn0%3d&docid=0011a5b5d7e8b43aca34c89cc26757915"));
        }
    }
}