using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanVibeRoastery
{
    public partial class RestClient : Form
    {
        public RestClient()
        {
            InitializeComponent();
        }
        #region UI Event Handlers 
        private void btnGo_Click(object sender, EventArgs e)
        {
            RestClientClass restClient = new RestClientClass();
            restClient.endpoint = txtRestURI.Text;
            debugging("REST Client created!");
            string strResponse = string.Empty;
            strResponse = restClient.makeRequest();
            debugging(strResponse);

        }
        #endregion

        private void debugging( string strDebugTxt)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugTxt + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugTxt + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }catch(Exception e)
            {
                System.Diagnostics.Debug.Write(e.Message, ToString() + Environment.NewLine);
            }
        }

      
    }
}
