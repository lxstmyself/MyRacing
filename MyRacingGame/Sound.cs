using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace MyRacingGame
{
    public class Sound
    {
        public static SoundPlayer music = new SoundPlayer("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Sound\\music.wav");
        public static SoundPlayer takeGas = new SoundPlayer("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Sound\\gasCan.wav");
        public static SoundPlayer explosion = new SoundPlayer("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Sound\\explosion.wav");
        public static SoundPlayer fire = new SoundPlayer("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Sound\\fire.wav");
        public static SoundPlayer countdown = new SoundPlayer("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Sound\\countdown.wav");
    }
}
