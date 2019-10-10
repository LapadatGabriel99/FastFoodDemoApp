using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FastFoodAppDemo
{
    /// <summary>
    /// !!!!remember to put credits
    /// Paper-Bag main page img "https://www.freepik.com/"
    /// Dish main page img "https://www.flaticon.com/authors/pause08"
    /// Restaurant main page img "https://www.freepik.com/"
    /// Notification main page img <div>Icons made by <a href="https://www.flaticon.com/authors/smashicons" title="Smashicons">Smashicons</a> from <a href="https://www.flaticon.com/" 			    title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" 			    title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>
    /// Settings main page img <div>Icons made by <a href="https://www.flaticon.com/authors/smashicons" title="Smashicons">Smashicons</a> from <a href="https://www.flaticon.com/" 			    title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" 			    title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>
    /// Close main page img <div>Icons made by <a href="https://www.flaticon.com/authors/smashicons" title="Smashicons">Smashicons</a> from <a href="https://www.flaticon.com/" 			title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" 			   title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>
    /// 
    /// --Links to facebook,instagram,twitter
    ///   facebook : https://www.facebook.com/JollibeePhilippines
    ///   instgram : https://www.instagram.com/jollibee/
    ///   twitter : https://twitter.com/jollibee
    /// 
    /// --Test Panel coordonates and size--
    ///   Location.X = 200
    ///   Location.Y = 185
    ///   size.width = 860
    ///   size.height = 459
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Click += new EventHandler(InstagramMark_Button_Click);
            this.Click += new EventHandler(FacebookMark_Button_Click);
            this.Click += new EventHandler(TwitterMark_Button_Click);
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new Size(0,1);
            TabControl.SizeMode = TabSizeMode.Fixed;
            InitializeSettings();
        }

        private void InitializeSettings()
        {
           //var x  = File.Open("C:\\Users\\Gabriel\\Desktop\\FileProject", FileMode.Open);
           
        }

        public MovingScrollBar MSB = new MovingScrollBar();
        public VisualizeWebPageThroughLink VWPTL_object = new VisualizeWebPageThroughLink();
        //public List<Control> ListOfControls = new List<Control>();
        //public List<Button> ListOfButtons = new List<Button>();
        ListOfControls controlList = new ListOfControls();
        ListOfButtons buttonList = new ListOfButtons();
        
        
        public void AddToListOfControls()
        {
            //ListOfControls.Add(firstCustomControl1);
            //ListOfControls.Add(secondCustomControl1);
            controlList.AddToList(firstCustomControl1);
            controlList.AddToList(secondCustomControl1);
        }

        public void AddToListOfButtons()
        {
            //ListOfButtons.Add(Home_Button);
            //ListOfButtons.Add(EatIn_button);
            buttonList.AddToList(Home_Button);
            buttonList.AddToList(EatIn_button);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Moving_Panel.Top = Home_Button.Top;
            //firstCustomControl1.BringToFront();
            //MovingScrollBar.DefaultLocation(ref Moving_Panel, firstCustomControl1, Home_Button);
            AddToListOfControls();
            AddToListOfButtons();
            Moving_Panel.Top = MSB.Default_Location();
            //ChangePages.BringPageToFront(controlList.ControlList[0] as Control);
            TabControl.SelectedTab = FirstTabControl;
            ObservableCollection<UserControl> obs = new ObservableCollection<UserControl>();  

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Test_Panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            //Moving_Panel.Top = Home_Button.Top;
            //firstCustomControl1.BringToFront();
            //MovingScrollBar.MoveLocation(ref Moving_Panel, firstCustomControl1, Home_Button);
            Moving_Panel.Top = MSB.Move_Location(buttonList.ButtonList[0] as Button);
            //ChangePages.BringPageToFront(controlList.ControlList[0] as Control);
            TabControl.SelectedTab = FirstTabControl;
        }

        private void EatIn_button_Click(object sender, EventArgs e)
        {
            //Moving_Panel.Top = EatIn_button.Top;
            //secondCustomControl1.BringToFront();
            //MovingScrollBar.MoveLocation(ref Moving_Panel, secondCustomControl1, EatIn_button);
            Moving_Panel.Top = MSB.Move_Location(buttonList.ButtonList[1] as Button);
            //ChangePages.BringPageToFront(controlList.ControlList[1] as Control);
            TabControl.SelectedTab = SecondTabControl;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Closing App"
                ,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if(dialog == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            //else if(dialog == DialogResult.No)
            //{
                
            //}
        }

        private void secondCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void InstagramMark_Button_Click(object sender, EventArgs e)
        {
            VWPTL_object.GoToInstagram();
        }

        private void FacebookMark_Button_Click(object sender, EventArgs e)
        {
            VWPTL_object.GoToFacebook();
        }

        private void TwitterMark_Button_Click(object sender, EventArgs e)
        {
            VWPTL_object.GoToTwitter();
        }

        private void firstCustomControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
