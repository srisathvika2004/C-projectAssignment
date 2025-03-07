using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    interface IPlayable
    {
        public void Play();
    }   
    class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("plays music");
        } 
 
    }
    class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("plays video");
        }
    }
}
