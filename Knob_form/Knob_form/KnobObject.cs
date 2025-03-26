namespace Knob_form
{
    internal class KnobObject
    {
        private byte[] handshake = new byte[3];
        private byte directionId;
        private byte direction;
        private byte positionId;
        private byte[] position = new byte[2];
        public KnobObject(string receivedData)
        {
            int i = 0;
            string cleanString = receivedData.Replace(" ", "").Replace("\0", "").Replace("\r",""); ;
            // Split the string into pairs of characters
            byte[] byteArray = Enumerable.Range(0, cleanString.Length / 2).Select(x => Convert.ToByte(cleanString.Substring(x * 2, 2), 16)).ToArray();
            for (i = 0; i < Handshake.Length; i++)
                Handshake[i] = byteArray[i];
            DirectionId = byteArray[i++];
            Direction = byteArray[i++];
            PositionId = byteArray[i++];
            int k = 0;
            for (int j = i; j < i + Position.Length; j++)
            {
                Position[k++] = byteArray[j];
            }


        }

        public byte[] Handshake { get => handshake; set => handshake = value; }
        public byte DirectionId { get => directionId; set => directionId = value; }
        public byte Direction { get => direction; set => direction = value; }
        public byte PositionId { get => positionId; set => positionId = value; }
        public byte[] Position { get => position; set => position = value; }
    }
}