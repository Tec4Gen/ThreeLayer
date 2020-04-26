using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FintessCenter.WinFormsPL;
using FitnessCenter.BLL.Interface;
using FitnessCenter.Common;
using FitnessCenter.Entities;
using FintessCenter.WinFormsPL;
using static FintessCenter.WinFormsPL.MainMenu;

namespace FintessCenter.WinFormsPL
{
    public partial class ClientForm : Form
    {
        private IClientLogic cleintlogic = DependenciesResolver.ClientLogic;

        GridClient _gridClient;
        public ClientForm()
        {
            InitializeComponent();
           
        }
        public ClientForm(GridClient gridclient)
        {
            this._gridClient = gridclient;
            InitializeComponent();
        }
        private void btnGetAllClient_Click(object sender, EventArgs e)
        {
            var ClientGetDataBase = cleintlogic.GetAll();
        
            if (ClientGetDataBase.Count() > 0)
            {
                MainMenu mainmenuClientGrid = new MainMenu();
                _gridClient(ClientGetDataBase);
            }
            else 
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.Text = "Клиентов нет";
                callbackMessage.Show();
            }

                   
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
