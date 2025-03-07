using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    public delegate void ButtonClickHandler();
    class Button
       
    {
        public event ButtonClickHandler OnClick;

        public void Click()
        {
            Console.WriteLine("Button clicked!");
            OnClick?.Invoke();  // Trigger the event
        }
    }
}
