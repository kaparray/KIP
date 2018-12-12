using System;

namespace Calculator
{
    interface ICalc
    {
        String Result { get; set; } 
        String Text_label { get; set; }
        String Label_memory { get; set; }
        String Operator { get; set; }
        String Unar_Operator { get; set; }

        String Last_button { get; set; } 
        String Memory_button { get; set; }
        String Separator { get; set; }

        event EventHandler<EventArgs> Digits;
        event EventHandler<EventArgs> Binar_Operators;
        event EventHandler<EventArgs> Unar_Operators;
        event EventHandler<EventArgs> Memory;
        event EventHandler<EventArgs> Controls_op;
        event EventHandler<EventArgs> Backspace;
        event EventHandler<EventArgs> Percent;
    }
}
