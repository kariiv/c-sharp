using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaPlacement
{
    public partial class Cinema : Form
    {
        readonly Functsions _keys = new Functsions();
        private string _labelLoginSign = "Login";
        private string _labelLogoutSign = "Logout";
        private string _writeUsername;
        private int _messageTimer = 0;
        public Cinema() {
            InitializeComponent();
            _keys.SetNumberOfSeats(LoadUpCountSeats());
            _keys.ReadSeatsFromDatabase();
            LoadSeats();
        }
        private void LoginLabel_MouseEnter(object sender, EventArgs e) {
            labelLogin.ForeColor = Color.Blue;
        }
        private void LoginLabel_MouseLeave(object sender, EventArgs e) {
            labelLogin.ForeColor = SystemColors.MenuHighlight;
        }
        public void Seats_MouseEnter(object sender, EventArgs e) {
            PictureBox selectedSeat = (PictureBox)sender;
            int seatStatus = _keys.CheckSeat(selectedSeat.Name, true);
            selectedSeat.Image = SeatsList.Images[seatStatus];
            NoteMessage(seatStatus, _keys.StringLastInt(selectedSeat.Name));
            labelMessages.Visible = true;
        }
        public void Seats_MouseLeave(object sender, EventArgs e) {
            PictureBox selectedSeat = (PictureBox)sender;
            selectedSeat.Image = SeatsList.Images[_keys.CheckSeat(selectedSeat.Name, false)];
        }
        public void Seats_MouseClick(object sender, MouseEventArgs e) {
            if (labelUsername.Visible) {
                string seatName = ((PictureBox) sender).Name;
                int seatNumber = _keys.StringLastInt(seatName); 
                int seatStatus = _keys.CheckSeat(seatName, true);
                if (seatStatus == 1) {
                    if (MessageBox.Show("Are you sure you want to buy seat nr " + seatNumber,
                            "Buying seat", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        _keys.BuyingSystem(seatNumber);
                        LoadSeats();
                    }
                }
                else if (seatStatus == 0) {
                    labelMessages.Text = "This seat is already your's";
                    if (MessageBox.Show("This is your seat. \nDo you wanna cancel this order?", "Cancel order",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        _keys.CancelOrder(seatNumber - 1);
                        LoadSeats();
                    }
                }
                else {
                    if(seatStatus == 4)
                        labelMessages.Text = "This seat is sold out";
                    else {
                        labelMessages.Text = "This seat is busy at the moment";
                    }
                }
            }
            else {
                labelMessages.Text = "Please login first!";
            }
        }
        private void NoteMessage(int seatStatus, int seatNumber) {
            if (seatStatus == 1 || seatStatus == 2)
                labelMessages.Text = "Seat " + seatNumber;
            else if (seatStatus == 3)
                labelMessages.Text = "Seat " + seatNumber + " (Busy)";
            else if (seatStatus == 0)
                labelMessages.Text = "Seat " + seatNumber + " (Your's)";
            else if (seatStatus == 4)
                labelMessages.Text = "Seat " + seatNumber + " (Sold)";
        }
        private void LoadSeats()
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(PictureBox))
                {
                    PictureBox seat = (PictureBox)control;
                    seat.Image = SeatsList.Images[_keys.CheckSeat(seat.Name, false)];
                }
            }
        }
        /// <summary>
        /// ///////////////////////////
        /// </summary>
        private int LoadUpCountSeats()
        {
            int seats = 1;
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(PictureBox))
                {
                    SeatProperties((PictureBox)control, seats);
                    seats += 1;
                }
            }
            return seats;
        }
        private void SeatProperties(PictureBox seat, int seatnumber)
        {
            seat.Name = "seat" + seatnumber;
            seat.MouseEnter += Seats_MouseEnter;
            seat.MouseLeave += Seats_MouseLeave;
            seat.MouseClick += Seats_MouseClick;
            seat.BackColor = Color.Transparent;
            seat.Anchor = AnchorStyles.None;
            seat.SizeMode = PictureBoxSizeMode.StretchImage;
            seat.Size = new Size(25, 25);
        }
        /// <summary>
        /// ////////////////////////////////////7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextLogin_TextChanged(object sender, EventArgs e) {
            if (!_keys.CheckLength(textLogin.Text)) {
                textLogin.Text = _writeUsername;
                labelMessages.Text = "Max 15 characters.";
            }
            else {
                _writeUsername = textLogin.Text;
            } 
        }
        private void TextLogin_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textLogin.Text)) {
                textLogin.Visible = false;
                AccountLogin();
            }
            else if (e.KeyCode == Keys.Enter) {
                labelMessages.Text = "Error, empty value";
            }
        }
        private void LoginLabel_Click(object sender, EventArgs e)
        {
            if (labelLogin.Text == _labelLoginSign)
                textLogin.Visible = true;
            else if (labelLogin.Text == _labelLogoutSign)
                AccountLogOut();
        }
        private void AccountLogOut() {
            _keys.Username = null;
            labelUsername.Text = null;
            labelUsername.Visible = false;
            labelLogin.Text = _labelLoginSign;
            LoadSeats();
        }
        private void AccountLogin() {
            _keys.Username = textLogin.Text.ToLower();
            labelUsername.Text = _keys.Username;
            labelUsername.Visible = true;
            labelLogin.Text = _labelLogoutSign;
            LoadSeats();
        }
        private void TextLogin_VisibleChanged(object sender, EventArgs e) {
            if(textLogin.Visible)
                textLogin.Text = null;
        }
        private void LabelMessages_TextChanged(object sender, EventArgs e) {
            labelMessages.Visible = true;
            _messageTimer = 0;
            messageCounter.Start();
        }
        private void MessageCounter_Tick(object sender, EventArgs e) {
            _messageTimer += 1;
            if (_messageTimer == 3) {
                labelMessages.Visible = false;
                labelMessages.Text = null;
                messageCounter.Stop();
            }
        }
        private void Cinema_Click(object sender, EventArgs e) {
            textLogin.Visible = false;
        }
    }
}