class MessageDecoder
{
    public string Decode(string message)
    {
        string decodedMessage = "";

        foreach (char c in message)
        {
            switch (c)
            {
                case '@':
                    decodedMessage += 'A';
                    break;

                case '3':
                    decodedMessage += 'E';
                    break;

                case '!':
                    decodedMessage += 'I';
                    break;

                case '0':
                    decodedMessage += 'O';
                    break;

                case '$':
                    decodedMessage += 'S';
                    break;

                default:
                    decodedMessage += c;
                    break;
            }
        }

        return decodedMessage;
    }
}