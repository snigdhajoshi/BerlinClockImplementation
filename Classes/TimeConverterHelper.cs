namespace BerlinClock.Classes
{
    public static class TimeConverterHelper
    {
        public static string GetRowString(short time, bool isfirstRow, bool isHour)
        {
            char[] row;
            int unitTimeInRow;
            char onLight, offLight = 'O';

            onLight = (isHour == true) ? 'R' : 'Y';
            unitTimeInRow = (isfirstRow == true) ? unitTimeInRow = time / 5 : unitTimeInRow = time % 5;
            row = (!isHour && isfirstRow) ? new char[11] : new char[4];

            if (unitTimeInRow > 0)
            {
                for (int i = 0; i < unitTimeInRow; i++)
                {
                    if (!isHour && isfirstRow && (i + 1) % 3 == 0)
                    {
                        //special red light for quaters of time in minute watch
                        row[i] = 'R';
                    }
                    else
                    {
                        row[i] = onLight;
                    }
                    
                }
                for (int j = unitTimeInRow; j < row.Length; j++)
                {
                    row[j] = offLight;
                }
            }
            else
            {
                for (int k = 0; k < row.Length; k++)
                {
                    row[k] = offLight;
                }
            }
            return new string(row);
        }
    }
}
