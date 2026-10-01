class MessageEncoder
{
    public string Encode(string message)
    {
        string encodedMessage = "";

        foreach (char c in message)
        {
            switch (char.ToUpper(c))
            {
                case 'A':
                    encodedMessage += '@';
                    break;

                case 'E':
                    encodedMessage += '3';
                    break;

                case 'I':
                    encodedMessage += '!';
                    break;

                case 'O':
                    encodedMessage += '0';
                    break;

                case 'S':
                    encodedMessage += '$';
                    break;

                default:
                    encodedMessage += c;
                    break;
            }
        }

        return encodedMessage;
    }
}