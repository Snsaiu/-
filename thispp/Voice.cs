using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace programmingQuickSetup
{
    class Voice
    {
        #region 单例模式
        //单例模式
        private static Voice _voice=null;
        public static Voice GetInstance()
        {
            Voice voice = new Voice();
            _voice = voice;
            return _voice;
        }
        #endregion

        #region 实现文字转语音
        public void TextToVoice(string text)
        {
            //SpeechSynthesizer voice = new SpeechSynthesizer();
            //voice.Rate = 0;
            //voice.Volume = 100;
            //voice.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
            //voice.Speak(text);
        }
        #endregion

    }
}
