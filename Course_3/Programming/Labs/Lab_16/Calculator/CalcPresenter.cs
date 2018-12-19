using System;

namespace Calculator
{
    class CalcPresenter
    {
        private readonly Model Calculations = new Model();
        private readonly ICalc _icalc;

        public CalcPresenter(ICalc icalc)
        {
            _icalc = icalc;
            _icalc.Digits += new EventHandler<EventArgs>(Digits);
            _icalc.Binar_Operators += new EventHandler<EventArgs>(Binar_operators);
            _icalc.Unar_Operators += new EventHandler<EventArgs>(Unar_operators);
            _icalc.Controls_op += new EventHandler<EventArgs>(Controls_op);
            _icalc.Backspace += new EventHandler<EventArgs>(Bspc);
            _icalc.Percent += new EventHandler<EventArgs>(Percent_method);
        }
        private void Digits(Object sender, EventArgs e)
        {
            if (_icalc.Last_button.Equals("operator") || _icalc.Last_button.Equals("Controls_op") || !_icalc.Unar_Operator.Equals(""))
                _icalc.Result = _icalc.Result[_icalc.Result.Length - 1].ToString();
            if (_icalc.Last_button.Equals("") && !_icalc.Result.EndsWith(_icalc.Separator))
                _icalc.Result = _icalc.Result.Remove(0, 1);
            if (!_icalc.Result.EndsWith(_icalc.Separator))
                _icalc.Result = Decimal.Parse(_icalc.Result).ToString();
            _icalc.Last_button = "digit";
            if (!_icalc.Unar_Operator.Equals(""))
            {
                _icalc.Unar_Operator = "";
            }
        }

        private void Binar_operators(Object sender, EventArgs e)
        {
            {
                if (_icalc.Last_button.Equals("digit") || _icalc.Last_button.Equals("Controls_op"))
                {
                    if (_icalc.Text_label.Equals("") || !_icalc.Unar_Operator.Equals(""))
                    {
                        Calculations.Binar_Operator = _icalc.Operator;
                        Calculations.Var1 = Double.Parse(_icalc.Result);
                        if (_icalc.Operator.Equals("/") || _icalc.Operator.Equals("*"))
                            Calculations.Var2 = 1;
                        else
                            Calculations.Var2 = 0;
                        Calculations.Calculate();
                        _icalc.Result = Calculations.Result.ToString();
                        if (!_icalc.Unar_Operator.Equals(""))
                            _icalc.Text_label += _icalc.Operator;
                        else
                        {
                            _icalc.Text_label += (Calculations.Var1.ToString() + _icalc.Operator);
                            _icalc.Unar_Operator = "";
                        }
                    }
                    else
                    {
                        Calculations.Var1 = Calculations.Result;
                        Calculations.Var2 = Double.Parse(_icalc.Result);
                        Calculations.Calculate();
                        Calculations.Binar_Operator = _icalc.Operator;
                        _icalc.Text_label += (Calculations.Var2.ToString() + _icalc.Operator);
                        _icalc.Result = Calculations.Result.ToString();
                    }
                }
                if (_icalc.Last_button.Equals("operator"))
                {
                    _icalc.Text_label = _icalc.Text_label.Remove(_icalc.Text_label.Length - 1, 1);
                    Calculations.Binar_Operator = _icalc.Operator;
                    _icalc.Text_label += _icalc.Operator;
                }
                _icalc.Last_button = "operator";
            }
        }

        private void Unar_operators(Object sender, EventArgs e)
        {
            switch (_icalc.Unar_Operator)
            {
                case "1/x":
                    Calculations.Unar_Operator = _icalc.Unar_Operator;
                    _icalc.Text_label += ("reciproc (" + _icalc.Result + ")");
                    _icalc.Result = Calculations.Calculate_unar_Operator(_icalc.Result).ToString();
                    break;
                case "Sqrt":
                    Calculations.Unar_Operator = _icalc.Unar_Operator;
                    _icalc.Text_label += ("sqrt (" + _icalc.Result + ")");
                    _icalc.Result = Calculations.Calculate_unar_Operator(_icalc.Result).ToString();
                    break;
                case "+-":
                    Calculations.Unar_Operator = _icalc.Unar_Operator;
                    _icalc.Result = Calculations.Calculate_unar_Operator(_icalc.Result).ToString();
                    break;
                case "Bspc":
                    if (_icalc.Last_button.Equals("digit"))
                    {
                        if (_icalc.Result.Length > 1)
                        {
                            _icalc.Result = _icalc.Result.Remove(_icalc.Result.Length - 1);
                        }
                        else
                        {
                            _icalc.Result = "0";
                        }
                    }
                    _icalc.Last_button = "digit";
                    break;
                case "CE":
                    _icalc.Result = "0";
                    break;
                default:
                    break;
            }
            _icalc.Last_button = "digit";
        }

        private void Controls_op(Object sender, EventArgs e)
        {
            switch (_icalc.Operator)
            {
                case "enter":
                    if (_icalc.Text_label.Equals(""))
                    {
                        Calculations.Var1 = Calculations.Result;
                        Calculations.Calculate();
                        _icalc.Text_label = "";
                        _icalc.Result = Calculations.Result.ToString();
                    }
                    else
                    {
                        if (!_icalc.Unar_Operator.Equals("") && _icalc.Operator.Equals(""))
                        {
                            _icalc.Text_label = "";
                        }
                        else
                        {
                            Calculations.Var1 = Calculations.Result;
                            Calculations.Var2 = Double.Parse(_icalc.Result);
                            Calculations.Calculate();
                            _icalc.Text_label = "";
                            _icalc.Result = Calculations.Result.ToString();
                        }
                    }
                    _icalc.Last_button = "Controls_op";
                    break;

                case "reset_all":
                    _icalc.Result = 0.ToString();
                    Calculations.Result = 0;
                    Calculations.Var1 = 0;
                    Calculations.Var2 = 0;
                    Calculations.Binar_Operator = "";
                    _icalc.Last_button = "";
                    _icalc.Operator = "";
                    _icalc.Text_label = "";
                    break;
                default:
                    break;
            }
            _icalc.Last_button = "Controls_op";
        }


        private void Bspc(Object sender, EventArgs e)
        {
            if (_icalc.Last_button.Equals("digit"))
            {
                if (_icalc.Result.Length > 1)
                {
                    _icalc.Result = _icalc.Result.Remove(_icalc.Result.Length - 1);
                }
                else
                {
                    _icalc.Result = "0";
                }
            }
        }

        private void Percent_method(Object sender, EventArgs e)
        {
            _icalc.Result = Calculations.Percent(_icalc.Result);
            _icalc.Text_label += _icalc.Result;
        }
    }
}
