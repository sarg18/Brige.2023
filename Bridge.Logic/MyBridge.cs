namespace Bridge.Logic
{
    public class MyBridge
    {
        private readonly string _text;


        public MyBridge(string text)
        {
            _text = text;
        }

        public String IsValide()
        {
            int count = 0;




            int n = _text[0];
            int m = _text[1];

            if (n == '*' && m== '*'  && _text.Length == 2) 
            {
                return "VALIDO";
            }

            if (n != '*' && _text[_text.Length - 1] != '*')
            {
                return "INVALIDO";
            }

            for (int i = 1; i < _text.Length - 1; i++)
            {
                if (!(_text[i].Equals('=') || _text[i].Equals('+')))
                {
                    return "INVALIDO";
                }
            }
            for (int i = 1; i < _text.Length - 1; i++)
            {
                if (!(_text[i].Equals(_text[_text.Length - i - 1])))
                {
                    return "INVALIDO";
                }
            }
            for (int i = 1; i < _text.Length - 1; i++)
            {
                if (_text[i].Equals('='))
                {
                    count++;

                    if (count > 2)
                    {
                        if (i - 1 != (int)(_text.Length / 2))
                        {
                            return "INVALIDO";
                        }
                    }
                }
                else
                {
                    count = 0;
                }
            }
            return "VALIDO";


        }

    }

}