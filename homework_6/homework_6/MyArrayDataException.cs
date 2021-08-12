using System;
using System.Collections.Generic;
using System.Text;

namespace homework_6
{
    [Serializable]
    class MyArrayDataException : Exception
    {
        int row, column;

        public MyArrayDataException(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}
