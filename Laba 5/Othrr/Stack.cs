using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Stack
    {
        private short _position;
        public object[] Obj;


        public short GetNum
        {
            get => _position;
        }

        public Stack()
        {
            Obj = new object[20];
            _position = 0;
        }

        #region Realise Stack

        

      

        public void StackAdd(object add)
        {
            Obj[_position] = add;
            _position++;
        }
        public void StackAdd(object add1, object add2, object add3, object add4,
            object add5, object add6)
        {
            Obj[_position] = add1;
            _position++;
            Obj[_position] = add2;
            _position++;
            Obj[_position] = add3;
            _position++;
            Obj[_position] = add5;
            _position++;
            Obj[_position] = add5;
            _position++;
            Obj[_position] = add6;
            _position++;

        }




        public object StackDelete()
        {
            _position--;
            return Obj[_position];
        }

        public void StackReplace(object rep)
        {
            if (_position > 0)
            {
                _position--;
                Obj[_position] = rep;
                _position++;
            }
            

        }

        #endregion

    }
}
