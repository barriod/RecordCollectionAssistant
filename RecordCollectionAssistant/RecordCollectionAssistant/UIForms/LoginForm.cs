using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecordCollectionAssistant.SystemControllers;
using RecordCollectionAssistant.UIForms;
using RecordCollectionAssistant.Data;
using RecordCollectionAssistant.CommandPattern;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace RecordCollectionAssistant.UIForms
{
    /// <summary>
    /// Form for handling login credentials/creation of accounts.
    /// </summary>
    public partial class LoginForm : Form
    {
        private const int REQ_PASS_LENGTH = 6;
        private AccountController controller;
        private RecordInvoker recordInvoker = new RecordInvoker();
        private RecordController recController = new RecordController();

        /// <summary>
        /// Constructor, first form so no needed params
        /// </summary>
        public LoginForm()
        {
            recordInvoker.clearStacks();
            recController.addInvoker(recordInvoker);
            controller = new AccountController(recController);
            InitializeComponent();
            resizeLogo();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Event handler for logging in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_btn_Click(object sender, EventArgs e)
        {

            Account acct = controller.verifyAccountLogin(username_txtBox.Text, password_txtBox.Text);

            if (acct != null)
            {
                this.Hide();
                ListRecordForm lrf = new ListRecordForm(recController);
                lrf.ShowDialog();
                this.Close();
            }

            else
                invalidcredentials_lbl.Text = "Invalid Credentials";
        }

        /// <summary>
        /// Form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            controller.readCurrentAccountsToList();
        }

        /// <summary>
        /// Account creation event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAccount_btn_Click(object sender, EventArgs e)
        {
            string potentialUser = username_txtBox.Text;
            string potentialPass = password_txtBox.Text;
            if (potentialUser != "" && password_txtBox.TextLength >= REQ_PASS_LENGTH && legalNames(potentialUser, potentialPass))
            {
                if (!controller.isDuplicateUsername(potentialUser))
                {
                    Account newAccount = new Account(potentialUser, potentialPass);
                    controller.addAccount(newAccount);
                    invalidcredentials_lbl.Text = "";
                    controller.writeNewAccountToFile(newAccount);
                    this.Hide();
                    ListRecordForm lrf = new ListRecordForm(recController);
                    lrf.ShowDialog();
                    this.Close();
                }
                else
                    invalidcredentials_lbl.Text = "Username Taken";
            }
            else if (password_txtBox.TextLength < REQ_PASS_LENGTH)
                invalidcredentials_lbl.Text = "Pass Too Short. (6+)";
            else
                invalidcredentials_lbl.Text = "Invalid Character: ' : '";
        }

        /// <summary>
        /// Ensures the credentials for the creation of an account are valid.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        private bool legalNames(string user, string pass)
        {
            return !(user.Contains(":") || pass.Contains(":"));
        }

        /// <summary>
        /// Form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            controller.readCurrentAccountsToList();
        }

        /// <summary>
        /// Resizing of logo image for form painting
        /// </summary>
        private void resizeLogo()
        {
            Image imgPhoto = Image.FromFile(controller.getRegularDirectoryPath() + "/ImagesBarcodes/RCA_logo_Finished_JPG.JPG");
                
            logo.Image = ResizeImage(imgPhoto, 200, 200);
        }

        /// <summary>
        /// Resizes image before resizeLogo uses resized image to paste on pictureBox.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
