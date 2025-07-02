using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Web;

namespace lab1
{
    class StateMachine
    {
        public static (List<double>, List<char>, List<char>) StatingDate(RichTextBox tb)
        {
            (List<double>, List<char>, List<char>) tuple;

            List<char> tmpList = new List<char>();
            List<char> data = new List<char>();
            List<char> letters = new List<char>();
            List<double> states = new List<double>();

            int count = 0;
            char tmp;
            double state = 0;

            while (count < tb.TextLength)
            {
                tmp = tb.Text[count];

                switch (state)
                {
                    case 0:
                        switch (tmp)
                        {
                            case '0': state = 0.2; break;
                            case '1': case '2': state = 0.1; break;
                            case '3': state = 0.3; break;
                            case '4': case '5': case '6': case '7': case '8': case '9': state = 1; break;
                            default: state = 0; tmpList.Clear(); break;
                        }
                        break;
                    case 0.1:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 1; break;
                            case '/': state = 2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 0.2:
                        switch (tmp)
                        {
                            case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 1; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 0.3:
                        switch (tmp)
                        {
                            case '0': case '1': state = 1; break;
                            case '/': state = 2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 1:
                        switch (tmp)
                        {
                            case '/': state = 2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 2:
                        switch (tmp)
                        {
                            case '0': state = 2.2; break;
                            case '1': state = 2.1; break;
                            case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 2.3; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 2.1:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': state = 2.3; break;
                            case '/': state = 3; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 2.2:
                        switch (tmp)
                        {
                            case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 2.3; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 2.3:
                        switch (tmp)
                        {
                            case '/': state = 3; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 3.1; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3.1:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 3.2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3.2:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 3.3; break;
                            case ':': state = 4; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3.3:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 3.4; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3.4:
                        switch (tmp)
                        {
                            case ':': state = 4; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 4:
                        switch (tmp)
                        {
                            case '0': case '1': state = 4.1; break;
                            case '2': state = 4.2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 4.1:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 4.3; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 4.2:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': state = 4.3; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 4.3:
                        switch (tmp)
                        {
                            case ':': state = 5; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 5:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': state = 5.1; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 5.1:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 5.2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 5.2:
                        switch (tmp)
                        {
                            case ':': state = 6; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 6:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': state = 6.1; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 6.1:
                        switch (tmp)
                        {
                            case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': state = 6.2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 6.2:
                        switch (tmp)
                        {
                            case ' ': state = 7; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 7:
                        switch (tmp)
                        {
                            default: state = 0; tmpList.RemoveAt(0); data.AddRange(tmpList); tmpList.Clear(); count--; break;
                        }
                        break;
                }
                count++;
                states.Add(state);
                tmpList.Add(tmp);
                letters.Add(tmp);
            }
            tuple.Item1 = states;
            tuple.Item2 = letters;
            tuple.Item3 = data;
            return tuple;
        }
        public static (List<double>, List<char>, List<char>) StatingAction(RichTextBox tb)
        {
            (List<double>, List<char>, List<char>) tuple;

            List<char> tmpList = new List<char>();
            List<char> data = new List<char>();
            List<char> letters = new List<char>();
            List<double> states = new List<double>();

            int count = 0;
            char tmp;
            double state = 0;


            while (count < tb.TextLength)
            {
                tmp = tb.Text[count];

                switch (state)
                {
                    case 0:
                        switch (tmp)
                        {
                            case '{': state = 1; break;
                            default: state = 0; tmpList.Clear(); break;
                        }
                        break;
                    case 1:
                        switch (tmp)
                        {
                            case 'G': state = 1.1; break;
                            case 'P': state = 1.2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 1.1:
                        switch (tmp)
                        {
                            case 'E': state = 1.3; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 1.2:
                        switch (tmp)
                        {
                            case 'O': state = 1.4; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 1.3:
                        switch (tmp)
                        {
                            case 'T': state = 1.5; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 1.4:
                        switch (tmp)
                        {
                            case 'S': state = 1.3; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 1.5:
                        switch (tmp)
                        {
                            case ' ': state = 2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 2:
                        switch (tmp)
                        {
                            case '/': state = 2.1; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 2.1:
                        switch (tmp)
                        {   
                            case '.': state = 2.2; break;
                            default:
                                if (tmp == '*' || tmp == '|' || tmp == ':' || tmp == '<' || tmp == '>' || tmp == '"' || tmp == '?' || tmp == '\\')
                                {
                                    state = 0;
                                    tmpList.Clear();
                                    count--;
                                    break;
                                }
                                state = 2.1; break;
                        }
                        break;
                    case 2.2:
                        switch (tmp)
                        {
                            case ' ': state = 3; break;
                            default:
                                if (tmp == '*' || tmp == '|' || tmp == ':' || tmp == '<' || tmp == '>' || tmp == '"' || tmp == '?' || tmp == '\\')
                                {
                                    state = 0;
                                    tmpList.Clear();
                                    count--;
                                    break;
                                }
                                state = 2.2; break;
                        }
                        break;
                    case 3:
                        switch (tmp)
                        {
                            case 'H': state = 3.1; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3.1:
                        switch (tmp)
                        {
                            case 'T': state = 3.2; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3.2:
                        switch (tmp)
                        {
                            case 'T': state = 3.3; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3.3:
                        switch (tmp)
                        {
                            case 'P': state = 3.4; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3.4:
                        switch (tmp)
                        {
                            case 'S': state = 3.5; break;
                            case '/': state = 4; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 3.5:
                        switch (tmp)
                        {
                            case '/': state = 4; break;
                            default: state = 0; tmpList.Clear(); count--; break;
                        }
                        break;
                    case 4:
                        switch (tmp)
                        {
                            case '.': state = 4.1 ; break;
                            default:
                                if (!Char.IsDigit(tmp)) { state = 0; tmpList.Clear(); count--; break; }
                                state = 4; break;
                        }
                        break;
                    case 4.1:
                        switch (tmp)
                        {
                            case '}': state = 5; break;
                            default:
                                if (!Char.IsDigit(tmp)) { state = 0; tmpList.Clear(); count--; break; }
                                state = 4.1; break;
                        }
                        break;
                    case 5:
                        switch (tmp)
                        {
                            default: state = 0; tmpList.RemoveAt(0); data.AddRange(tmpList); tmpList.Clear(); count--; break;
                        }
                        break;
                }
                count++;
                states.Add(state);
                tmpList.Add(tmp);
                letters.Add(tmp);
            }
            tuple.Item1 = states;
            tuple.Item2 = letters;
            tuple.Item3 = data;
            return tuple;
        }
    }
}
