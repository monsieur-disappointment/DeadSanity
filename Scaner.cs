using System.Collections.Generic;

namespace lab1
{
    public enum TokenType
    {
        Function,       //scanf
        Parameters,     //(
        String,         //"
        Specification,  //%
        EndString,      //"
        EndOptions,     //,
        Address,        //&
        Name,
        EndParameters,  //)
        EndFunction,    //;
        Error,          
        FunctionError,  
        Undefined,      
        EOF             
    }
    public class Token
    {
        public TokenType Type { get; set; }
        public string Value { get; set; }
        public int Position { get; set; }

        public Token(TokenType type, string value, int position)
        {
            Type = type;
            Value = value;
            Position = position;
        }

        public Token() { }
    }

    public class Scaner
    {
        private readonly string _text;
        private int _position;
        private int errorPos = -1;

        private char CurrentChar => _position < _text.Length ? _text[_position] : '\0';

        public Scaner(string text)
        {
            _text = text;
        }

        public int GetPosition()
        {
            return _position;
        }

        private void SetNextPosition()
        {
            _position++;
        }

        private void SkipWhiteSpace()
        {
            while (char.IsWhiteSpace(CurrentChar))
            {
                SetNextPosition();
            }
        }

        private (string, bool) CheckFunction()
        {
            int state = 0;
            string result = "";
            while (state != 4 && state != -1)
            {
                switch (state)
                {
                    case 0:
                        {
                            if (CurrentChar == 'c') { state = 1; result += CurrentChar; SetNextPosition(); }
                            else { state = -1; errorPos = GetPosition(); }
                            break;
                        }
                    case 1:
                        {
                            if (CurrentChar == 'a') { state = 2; result += CurrentChar; SetNextPosition(); }
                            else { state = -1; errorPos = GetPosition(); }
                            break;
                        }
                    case 2:
                        {
                            if (CurrentChar == 'n') { state = 3; result += CurrentChar; SetNextPosition(); }
                            else { state = -1; errorPos = GetPosition(); }
                            break;
                        }
                    case 3:
                        {
                            if (CurrentChar == 'f') { state = 4; result += CurrentChar; SetNextPosition(); }
                            else { state = -1; errorPos = GetPosition(); }
                            break;
                        }
                    default: break;
                }
            }
            if (state == -1)
                return (result += CurrentChar, false);
            return (result, true);
        }

        private (string, bool) CheckSpec()
        {
            string result = "%";
            if (CurrentChar == 's' || CurrentChar == 'f' || CurrentChar == 'd')
            {
                result += CurrentChar;
                return (result, true);
            }
            else return (result, false);
        }

        private (string, bool) CheckName()
        {
            string result = "";
            if (char.IsLetter(CurrentChar))
            {
                result += CurrentChar;
                SetNextPosition();
                while (char.IsLetter(CurrentChar) || char.IsDigit(CurrentChar))
                {
                    result += CurrentChar;
                    SetNextPosition();
                }
                return (result, true);
            }
            else
            {
                return (result += CurrentChar, false);
            }
        }

        private (string, bool) CheckString()
        {
            string result = "\"";
            while (CurrentChar != '"')
            {
                if (CurrentChar == '\0')
                {
                    return (result, false);
                }
                SetNextPosition();
            }
            return (result += "\"", true);
        }

        public Token GetNextToken()
        {
            int position = GetPosition();
            while (CurrentChar != '\0')
            {
                string lx;
                switch (CurrentChar)
                {
                    case 's':
                        {

                            int tmpPos = GetPosition();
                            SetNextPosition();
                            var res1 = CheckFunction();
                            lx = "s";
                            if (res1.Item2)
                            {
                                lx += res1.Item1;
                                return new Token(TokenType.Function, lx, position);
                            }
                            else
                            {
                                _position = tmpPos;
                                var res6 = CheckName();
                                if (res6.Item2)
                                {
                                    lx = res6.Item1;
                                    return new Token(TokenType.Name, lx, position + res6.Item1.Length - 1);
                                }
                                else
                                {
                                    lx += res1.Item1;
                                    _position = errorPos;
                                    return new Token(TokenType.FunctionError, lx, errorPos);
                                }
                            }
                        }
                    case '(':
                        {
                            SetNextPosition();
                            return new Token(TokenType.Parameters, "(", position);
                        }
                    case '\"':
                        {
                            SetNextPosition();
                            int tmp = _position;
                            if (CheckString().Item2)
                            {
                                _position = tmp;
                                return new Token(TokenType.String, "\"", position);
                            }
                            else if (!CheckString().Item2)
                            {
                                _position = tmp;
                                return new Token(TokenType.EndString, "\"", position);
                            }
                            else return new Token(TokenType.Error, "\"", position);
                        }
                    case '%':
                        {
                            SetNextPosition();
                            var res3 = CheckSpec();
                            lx = res3.Item1;
                            if (res3.Item2)
                            {
                                SetNextPosition();
                                return new Token(TokenType.Specification, lx, position);
                            }
                            else
                            {
                                return new Token(TokenType.Error, lx, position);
                            }
                        }
                    case ',':
                        {
                            SetNextPosition();
                            return new Token(TokenType.EndOptions, ",", position);
                        }
                    case '&':
                        {
                            SetNextPosition();
                            return new Token(TokenType.Address, "&", position);
                        }
                    case ')':
                        {
                            SetNextPosition();
                            return new Token(TokenType.EndParameters, ")", position);
                        }
                    case ';':
                        {
                            SetNextPosition();
                            return new Token(TokenType.EndFunction, ";", position);
                        }

                    default:
                        {
                            if (char.IsLetter(CurrentChar))
                            {
                                var res5 = CheckName();
                                if (res5.Item2)
                                {
                                    return new Token(TokenType.Name, res5.Item1, position);
                                }
                                else
                                {
                                    SetNextPosition();
                                    return new Token(TokenType.Error, res5.Item1, position);
                                }
                            }
                            string curChar = CurrentChar.ToString();
                            SetNextPosition();
                            return new Token(TokenType.Undefined, curChar, position);
                        }
                }
            }
            return new Token(TokenType.EOF, "", position);
        }

        public Token[] Tokenize()
        {
            var tokens = new List<Token>();
            Token token;
            do
            {
                SkipWhiteSpace();
                token = GetNextToken();
                tokens.Add(token);
            } while (token.Type != TokenType.EOF);
            return tokens.ToArray();
        }

        public string Analyse()
        {
            string outputText = null;
            var tokens = Tokenize();
            int state = 0;
            Token prevToken = new Token();
            prevToken.Position = -2;
            prevToken.Value = "0";
            bool successfully = true;
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[0].Type == TokenType.EOF)
                {
                    outputText += "Пустая строка\n";
                    break;
                }
                switch (state)
                {
                    case 0:
                        {
                            if (tokens[i].Type == TokenType.Function) state = 1;
                            else if (tokens[i].Type == TokenType.FunctionError || tokens[i].Type == TokenType.Name)
                            {
                                state = 1;
                                outputText += "Ошибка в имени функции. Позиция: " + (tokens[i].Position + 1) + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.FunctionError || tokens[i + 1].Type == TokenType.Name)
                                    i++;
                                successfully = false;
                                break;
                            }
                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                outputText += "Функция не найдена.";
                                successfully = false;
                            }
                            break;
                        }
                    case 1:
                        {
                            if (tokens[i].Type == TokenType.Parameters) state = 2;
                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                state = 1;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неизвестный символ: " + tokens[i].Value + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Error)
                            {
                                state = 1;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидалась открывающая скобка: (\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type > TokenType.Parameters && tokens[i].Type <= TokenType.EndFunction || tokens[i].Type < TokenType.Parameters)
                            {
                                state = 2;
                                i--;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидалась открывающая скобка: (\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.EOF)
                            {
                                state = 0;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидалась открывающая скобка: (\n";
                                successfully = false;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (tokens[i].Type == TokenType.String || tokens[i].Type == TokenType.EndString) state = 3;
                            else if (tokens[i].Type == TokenType.EOF)
                            {
                                state = 0;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидались кавычки: \"\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                state = 2;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неизвестный символ: " + tokens[i].Value + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                successfully = false;
                            }
                            else if (tokens[i].Type > TokenType.String && tokens[i].Type <= TokenType.EndFunction)
                            {
                                state = 3;
                                i--;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидались кавычки: \"\n";
                                successfully = false;
                            }
                            else if(tokens[i].Type == TokenType.Error || tokens[i].Type < TokenType.String)
                            {
                                state = 2;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидались кавычки: \"\n";
                                successfully = false;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (tokens[i].Type == TokenType.Specification) state = 4;
                            else if (tokens[i].Type == TokenType.EOF)
                            {
                                state = 0;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидался параметр\n";
                                successfully = false;
                            }
                            else if(tokens[i].Type > TokenType.Specification && tokens[i].Type <= TokenType.EndFunction)
                            {
                                state = 4;
                                i--;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидался спецификатор\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Error || tokens[i].Type < TokenType.Specification)
                            {
                                state = 3;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидался спецификатор\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                state = 3;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неизвестный символ: " + tokens[i].Value + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                successfully = false;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (tokens[i].Type == TokenType.EndString || tokens[i].Type == TokenType.String) state = 5;
                            else if (tokens[i].Type == TokenType.EOF)
                            {
                                state = 0;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидались кавычки: \"\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                state = 4;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неизвестный символ: " + tokens[i].Value + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                successfully = false;
                            }
                            else if (tokens[i].Type > TokenType.EndString && tokens[i].Type <= TokenType.EndFunction)
                            {
                                state = 5;
                                i--;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидались кавычки: \"\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Error || tokens[i].Type < TokenType.EndString)
                            {
                                state = 4;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидались кавычки: \"\n";
                                successfully = false;
                            }
                            break;
                        }
                    case 5:
                        {
                            if (tokens[i].Type == TokenType.EndOptions) state = 6;
                            else if (tokens[i].Type == TokenType.EOF)
                            {
                                state = 0;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидался разделитель параметров: ,\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type > TokenType.EndOptions && tokens[i].Type <= TokenType.EndFunction)
                            {
                                state = 6;
                                i--;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидался разделитель параметров: ,\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Error || tokens[i].Type < TokenType.EndOptions)
                            {
                                state = 5;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидался разделитель параметров: ,\n";
                                successfully = false;
                            }

                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                state = 5;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неизвестный символ: " + tokens[i].Value + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                successfully = false;
                            }
                            break;
                        }
                    case 6:
                        {
                            if (tokens[i].Type == TokenType.Address) state = 7;
                            else if (tokens[i].Type == TokenType.EOF)
                            {
                                state = 0;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидался параметр\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type > TokenType.Address && tokens[i].Type <= TokenType.EndFunction)
                            {
                                state = 7;
                                i--;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Переменная должна передаваться по адресу\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Error || tokens[i].Type < TokenType.Address)
                            {
                                state = 6;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Переменная должна передаваться по адресу\n";
                                successfully = false;

                            }
                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                state = 6;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неизвестный символ: " + tokens[i].Value + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                successfully = false;
                            }
                            break;
                        }
                    case 7:
                        {
                            if (tokens[i].Type == TokenType.Name) state = 8;
                            else if (tokens[i].Type == TokenType.EOF)
                            {
                                state = 0;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидался параметр\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type > TokenType.Name && tokens[i].Type <= TokenType.EndFunction)
                            {
                                state = 8;
                                i--;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неверное название переменной\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Error || tokens[i].Type == TokenType.FunctionError || tokens[i].Type < TokenType.Name)
                            {
                                state = 7;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неверное название переменной\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                state = 7;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неизвестный символ: " + tokens[i].Value + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                successfully = false;
                            }
                            break;
                        }
                    case 8:
                        {
                            if (tokens[i].Type == TokenType.EndParameters) state = 9;
                            else if (tokens[i].Type == TokenType.EOF)
                            {
                                state = 0;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидалась закрывающая скобка: )\n";
                                successfully = false;
                            }
                            else if(tokens[i].Type > TokenType.EndParameters && tokens[i].Type <= TokenType.EndFunction || tokens[i].Type < TokenType.EndParameters)
                            {
                                state = 9;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидалась закрывающая скобка: )\n";
                                i--;
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Error)
                            {
                                state = 8;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидалась закрывающая скобка: )\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                state = 8;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неизвестный символ: " + tokens[i].Value + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                successfully = false;
                            }
                            break;
                        }
                    case 9:
                        {
                            if (tokens[i].Type == TokenType.EndFunction) state = 10;
                            else if (tokens[i].Type == TokenType.EOF)
                            {
                                state = 0;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидалось: ;\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type > TokenType.EndFunction && tokens[i].Type <= TokenType.EndFunction || tokens[i].Type < TokenType.EndFunction)
                            {
                                state = 10;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидалось: ;\n";
                                i--;
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Error)
                            {
                                state = 9;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Ожидалось: ;\n";
                                successfully = false;
                            }
                            else if (tokens[i].Type == TokenType.Undefined)
                            {
                                state = 9;
                                outputText += "Ошибка. Позиция: " + (tokens[i].Position + 1) + " Неизвестный символ: " + tokens[i].Value + "\n";
                                while (tokens[i + 1].Type != TokenType.EOF && tokens[i + 1].Type == TokenType.Undefined)
                                    i++;
                                successfully = false;
                            }
                            break;
                        }
                    case 10:
                        {
                            if (tokens[i].Type == TokenType.EOF && successfully) outputText += "Ошибок нет. Конец разбора.";
                            else
                            {
                                if (successfully) outputText += "Ошибок нет. Продолжение разбора.";
                                i--;
                                state = 0;
                            }
                            break;
                        }
                    default: break;
                }
                prevToken = tokens[i];
            }
            return outputText;
        }
    }
}
