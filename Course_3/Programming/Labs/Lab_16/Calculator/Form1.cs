using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form, ICalc
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public String Result
        {
          get { return result_window.Text; }
          set { result_window.Text = value; }
        }
        public String Text_label
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public String Label_memory
        {
            get { return labelMemory.Text; }
            set { labelMemory.Text = value; }
        }
        public String Separator { get; set; } = ".";
        public String Operator { get; set; } = "";
        public String Unar_Operator { get; set; } = "";
        public String Last_button { get; set; } = "";
        public String Memory_button { get; set; }

        public event EventHandler<EventArgs> Digits;
        public event EventHandler<EventArgs> Binar_Operators;
        public event EventHandler<EventArgs> Unar_Operators;
        public event EventHandler<EventArgs> Memory;
        public event EventHandler<EventArgs> Controls_op;
        public event EventHandler<EventArgs> Backspace;
        public event EventHandler<EventArgs> Percent;

   

        #region Digits Clicks 
        ///digits
        private void one_Click(Object sender, EventArgs e)
        { 
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void two_Click(Object sender, EventArgs e)
        {
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void three_Click(Object sender, EventArgs e)
        {
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void four_Click(Object sender, EventArgs e)
        {
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void five_Click(Object sender, EventArgs e)
        {
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void six_Click(Object sender, EventArgs e)
        {
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void seven_Click(Object sender, EventArgs e)
        {
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
        }

        private void eight_Click(Object sender, EventArgs e)
        {
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void nine_Click(Object sender, EventArgs e)
        {
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void zero_Click(Object sender, EventArgs e)
        {
            result_window.Text += (sender as Button).Text;
            Digits?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void dout_MouseClick(Object sender, MouseEventArgs e)
        {
            try
            {
                Decimal.Parse("0" + Separator);
                if (!result_window.Text.Contains(Separator))
                {
                    result_window.Text += Separator;
                    Digits?.Invoke(this, EventArgs.Empty);
                }
                equals.Focus();
            }
            catch
            {
                Separator = ",";
                if (!result_window.Text.Contains(Separator))
                {
                    result_window.Text += Separator;
                    Digits?.Invoke(this, EventArgs.Empty);
                }
                equals.Focus();
            }
        }

        #endregion

        ///Unar_Operators

        private void onebyx_Click(Object sender, EventArgs e)
        {
            Unar_Operator = "1/x";
            try
            {
                Unar_Operators?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                result_window.Text = "Divide by zero -> hit C";
                foreach (Control item in Controls)
                {
                    if (item as Button != null)
                        (item as Button).Enabled = false;
                }
                reset.Enabled = true;
            }
            equals.Focus();
        }

        private void Sign_Click(Object sender, EventArgs e)
        {
            Unar_Operator = "+-";
            Unar_Operators?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void sqrt_Click(Object sender, EventArgs e)
        {
            Unar_Operator = "Sqrt";
            try
            {
                Unar_Operators?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                result_window.Text = "Divide by zero -> hit C";
                foreach (Control item in Controls)
                {
                    if (item as Button != null)
                        (item as Button).Enabled = false;
                }
                reset.Enabled = true;
            }
            equals.Focus();
        }

        private void Bspc_Click(Object sender, EventArgs e)
        {
            Backspace?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void CE_Click(Object sender, EventArgs e)
        {
            Unar_Operator = "CE";
            Unar_Operators?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }


        //////operators
        #region binar operators
        private void plus_Click(Object sender, EventArgs e)
        {
            Operator = (sender as Button).Text;
            try
            {
                Binar_Operators?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                result_window.Text = "Divide by zero -> hit C";
                foreach (Control item in Controls)
                {
                    if (item as Button != null)
                        (item as Button).Enabled = false;
                }
                reset.Enabled = true;
            }
            equals.Focus();
        }

        private void minus_Click(Object sender, EventArgs e)
        {
            Operator = (sender as Button).Text;
            try
            {
                Binar_Operators?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                result_window.Text = "Divide by zero -> hit C";
                foreach (Control item in Controls)
                {
                    if (item as Button != null)
                        (item as Button).Enabled = false;
                }
                reset.Enabled = true;
            }
            equals.Focus();
        }

        private void multiply_Click(Object sender, EventArgs e)
        {
            Operator = (sender as Button).Text;
            try
            {
                Binar_Operators?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                result_window.Text = "Divide by zero -> hit C";
                foreach (Control item in Controls)
                {
                    if (item as Button != null)
                        (item as Button).Enabled = false;
                }
                reset.Enabled = true;
            }
            equals.Focus();
        }

        private void devide_Click(Object sender, EventArgs e)
        {
            Operator = (sender as Button).Text;
            try
            {
                Binar_Operators?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                result_window.Text = "Divide by zero -> hit C";
                foreach (Control item in Controls)
                {
                    if (item as Button != null)
                        (item as Button).Enabled = false;
                }
                reset.Enabled = true;
            }
            equals.Focus();
        }
        #endregion

        ///Controls
        private void equals_Click(Object sender, EventArgs e)
        {
            Operator = "enter";
            try
            {
                Controls_op?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                result_window.Text = "Divide by zero -> hit C";
                foreach (Control item in Controls)
                {
                    if (item as Button != null)
                        (item as Button).Enabled = false;
                }
                reset.Enabled = true;
            }
            equals.Focus();
        }

        private void reset_Click(Object sender, EventArgs e)
        {
            Operator = "reset_all";
            foreach (Control item in Controls)
            {
                if (item as Button != null)
                    (item as Button).Enabled = true;
            }
            Controls_op?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        ///Memory
        private void MR_Click(Object sender, EventArgs e)
        {
            Memory_button = (sender as Button).Text;
            Memory?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void MS_Click(Object sender, EventArgs e)
        {
            Memory_button = (sender as Button).Text;
            Memory?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void MC_Click(Object sender, EventArgs e)
        {
            Memory_button = (sender as Button).Text;
            Memory?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void Mplus_Click(Object sender, EventArgs e)
        {
            Memory_button = (sender as Button).Text;
            Memory?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void Mminus_Click(Object sender, EventArgs e)
        {
            Memory_button = (sender as Button).Text;
            Memory?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }

        private void persent_Click(Object sender, EventArgs e)
        {
            Percent?.Invoke(this, EventArgs.Empty);
            equals.Focus();
        }


        ///Keys
        private void Form1_KeyDown(Object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    Backspace?.Invoke(this, EventArgs.Empty);
                    equals.Focus();
                    break;
                case Keys.Enter:
                    Operator = "enter";
                    try
                    {
                        Controls_op?.Invoke(this, EventArgs.Empty);
                    }
                    catch
                    {
                        result_window.Text = "Divide by zero -> hit C";
                        foreach (Control item in Controls)
                        {
                            if (item as Button != null)
                                (item as Button).Enabled = false;
                        }
                        reset.Enabled = true;
                    }
                    break;
                case Keys.Multiply:
                    Operator = "*";
                    try
                    {
                        Binar_Operators?.Invoke(this, EventArgs.Empty);
                    }
                    catch
                    {
                        result_window.Text = "Divide by zero -> hit C";
                        foreach (Control item in Controls)
                        {
                            if (item as Button != null)
                                (item as Button).Enabled = false;
                        }
                        reset.Enabled = true;
                    }
                    break;
                case Keys.Add:
                    Operator = "+";
                    try
                    {
                        Binar_Operators?.Invoke(this, EventArgs.Empty);
                    }
                    catch
                    {
                        result_window.Text = "Divide by zero -> hit C";
                        foreach (Control item in Controls)
                        {
                            if (item as Button != null)
                                (item as Button).Enabled = false;
                        }
                        reset.Enabled = true;
                    }
                    break;
                case Keys.Subtract:
                    Operator = "-";
                    try
                    {
                        Binar_Operators?.Invoke(this, EventArgs.Empty);
                    }
                    catch
                    {
                        result_window.Text = "Divide by zero -> hit C";
                        foreach (Control item in Controls)
                        {
                            if (item as Button != null)
                                (item as Button).Enabled = false;
                        }
                        reset.Enabled = true;
                    }
                    break;
                case Keys.Decimal:
                    try
                    {
                        Decimal.Parse("0" + Separator);
                        if (!result_window.Text.Contains(Separator))
                        {
                            result_window.Text += Separator;
                            Digits?.Invoke(this, EventArgs.Empty);
                        }
                        equals.Focus();
                    }
                    catch
                    {
                        Separator = ",";
                        if (!result_window.Text.Contains(Separator))
                        {
                            result_window.Text += Separator;
                            Digits?.Invoke(this, EventArgs.Empty);
                        }
                        equals.Focus();
                    }
                    break;
                case Keys.Divide:
                    Operator = "/";
                    try
                    {
                        Binar_Operators?.Invoke(this, EventArgs.Empty);
                    }
                    catch
                    {
                        result_window.Text = "Divide by zero -> hit C";
                        foreach (Control item in Controls)
                        {
                            if (item as Button != null)
                                (item as Button).Enabled = false;
                        }
                        reset.Enabled = true;
                    }
                    break;
                default:
                    if (e.KeyCode.ToString().StartsWith("NumPad"))
                    {
                        result_window.Text += e.KeyCode.ToString().Substring(6);
                        Digits?.Invoke(this, EventArgs.Empty);
                    }
                    if (e.KeyCode.ToString().StartsWith("D"))
                    {
                        result_window.Text += e.KeyCode.ToString().Substring(1);
                        Digits?.Invoke(this, EventArgs.Empty);
                    }
                    break;
            }
        }

        #region смена цвета кнопок
    
     

        private void Bspc_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void Bspc_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void CE_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void CE_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void reset_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void reset_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void Sign_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void Sign_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void sqrt_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void sqrt_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void devide_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void devide_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void persent_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void persent_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void multiply_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void multiply_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void onebyx_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void onebyx_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void minus_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void minus_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void plus_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void plus_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void equals_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void equals_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.MintCream;
        }

        private void seven_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void seven_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void eight_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void eight_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void nine_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void nine_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void four_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void four_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void five_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void five_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void six_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void six_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void one_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void one_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void two_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void two_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void three_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void three_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void zero_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void zero_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }

        private void dout_MouseEnter(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Yellow;
        }

        private void dout_MouseLeave(Object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.LightYellow;
        }
        #endregion 
    }
}
