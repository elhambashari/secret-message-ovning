// Create objects for encoding and decoding messages
MessageEncoder encoder = new MessageEncoder();
MessageDecoder decoder = new MessageDecoder();

bool running = true;

// Keep showing the menu until the user chooses Exit
while (running)
{
    Console.WriteLine("\n--- Secret Message Machine ---");
    Console.WriteLine("1. Encode message");
    Console.WriteLine("2. Decode message");
    Console.WriteLine("3. Exit");

    int choice = InputHelper.ReadChoice();

    switch (choice)
    {
        case 1:
            string messageToEncode =
                InputHelper.ReadString("Skriv meddelandet som du vill koda: ");

            string encodedMessage = encoder.Encode(messageToEncode);

            Console.WriteLine($"Kodat meddelande: {encodedMessage}");
            break;

        case 2:
            string messageToDecode =
                InputHelper.ReadString("Skriv meddelandet som du vill avkoda: ");

            string decodedMessage = decoder.Decode(messageToDecode);

            Console.WriteLine($"Avkodat meddelande: {decodedMessage}");
            break;

        case 3:
            Console.WriteLine("Programmet avslutas.");
            running = false;
            break;

        default:
            Console.WriteLine("Ogiltigt val. Välj 1, 2 eller 3.");
            break;
    }
}
