using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using System.IO;

namespace CoTuong
{
    class Music
    {

        static private WMPLib.WindowsMediaPlayer mediaPlayerSound = new WMPLib.WindowsMediaPlayer();
        static private WMPLib.WindowsMediaPlayer mediaPlayerBGMusic = new WMPLib.WindowsMediaPlayer();
        static private string URL_StartGame = Application.StartupPath + @"\Data\Music\StartGameAndCheckmate.mp3";
        static private string URL_EatChess = Application.StartupPath + @"\Data\Music\eat_chess.mp3";
        static private string URL_MoveChess = Application.StartupPath + @"\Data\Music\moveChess.mp3";
        static private string URL_Error = Application.StartupPath + @"\Data\Music\ErrorCheckmate.mp3";
        static private string URL_Button = Application.StartupPath + @"\Data\Music\button.mp3";
        static private string URL_Win = Application.StartupPath + @"\Data\Music\WinMusic.mp3";
        static private string URL_Lose = Application.StartupPath + @"\Data\Music\LoseMusic.mp3";


        static private XmlDocument xmlDocument = new XmlDocument();
        static private string URL_BgMusic = Application.StartupPath + @"\Data\Music\bgMusic.mp3";
        static private string FileNameSetting = Application.StartupPath + @"\Data\Setting\Setting.xml";
        static private bool isPlaySound = true;
        static private bool isPlayMusic = true;
        static private int volumeOfSound = 100;
        static private int volumeOfMusicBg = 100;

        public static int VolumeOfSound { get => volumeOfSound; }
        public static int VolumeOfMusicBg { get => volumeOfMusicBg; }
        public static bool IsPlaySound
        {
            get => isPlaySound; private set
            {
                isPlaySound = value;
                if (!isPlaySound)
                    mediaPlayerSound.controls.stop();
            }
        }
        public static bool IsPlayMusic
        {
            get => isPlayMusic; private set
            {
                isPlayMusic = value;
                if (!isPlayMusic)
                    mediaPlayerBGMusic.controls.stop();
                else
                    mediaPlayerBGMusic.controls.play();
            }
        }

        static public void LoadMusic()
        {

            mediaPlayerSound.settings.setMode("autoRewind", false);
            mediaPlayerSound.settings.setMode("loop", false);
            mediaPlayerSound.settings.volume = VolumeOfSound;
            mediaPlayerSound.controls.stop();


            mediaPlayerBGMusic.settings.setMode("autoRewind", true);
            mediaPlayerBGMusic.settings.setMode("loop", true);
            mediaPlayerBGMusic.settings.volume = VolumeOfMusicBg;
            mediaPlayerBGMusic.URL = URL_BgMusic;
            mediaPlayerBGMusic.controls.stop();
            

        }
        public static void LoadSetting()
        {
            if (!File.Exists(FileNameSetting))
            {
                WriteFileForSetting(true, true, 100, 100);
            }
            xmlDocument.Load(FileNameSetting);
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/Setting");
            XmlNode xmlNode = xmlNodeList.Item(0);
            IsPlayMusic = int.Parse(xmlNode["IsHaveMusicBg"].InnerText) == 1;
            IsPlaySound = int.Parse(xmlNode["IsHaveSound"].InnerText) == 1;
            mediaPlayerBGMusic.settings.volume = volumeOfMusicBg = int.Parse(xmlNode["VolumnMusicBg"].InnerText);
            mediaPlayerSound.settings.volume = volumeOfSound = int.Parse(xmlNode["VolumnSound"].InnerText);

        }

        #region Cài đặt
        public static void WriteFileForSetting(bool isHaveMusicBg, bool isHaveSound,
            int VolumnMusic, int VolumnSound)
        {
            int tmp1 = isHaveMusicBg ? 1 : 0;
            int tmp2 = isHaveSound ? 1 : 0;
            using (XmlTextWriter xtw = new XmlTextWriter(FileNameSetting, null))
            {
                xtw.Formatting = Formatting.Indented;
                xtw.WriteStartDocument();
                xtw.WriteStartElement("Setting");
                xtw.WriteElementString("IsHaveMusicBg", tmp1.ToString());
                xtw.WriteElementString("IsHaveSound", tmp2.ToString());
                xtw.WriteElementString("VolumnMusicBg", VolumnMusic.ToString());
                xtw.WriteElementString("VolumnSound", VolumnSound.ToString());
                xtw.WriteEndElement();
                xtw.WriteEndDocument();
                xtw.Flush();
                xtw.Close();
            }
        }

        public static void SetElementsTempForSetting(bool isHaveMusicBg, bool isHaveSound, int VolumnMusic, int VolumnSound)
        {
            IsPlayMusic = isHaveMusicBg;
            IsPlaySound = isHaveSound;
            mediaPlayerBGMusic.settings.volume = VolumnMusic;
            mediaPlayerSound.settings.volume = VolumnSound;
        }
        #endregion

        #region phát âm thanh
        /// <summary>
        /// Phát nhạc nền
        /// </summary>
        static public void PlayBgMusic()
        {
            LoadSetting();
            if (!IsPlayMusic)
                return;
            mediaPlayerBGMusic.controls.play();
        }
        /// <summary>
        /// Phát âm thanh bắt đầu game và chiếu tướng
        /// </summary>
        static public void PlayStartGameAndCheckmate()
        {
            if (!IsPlaySound)
            {
                return;
            }
            mediaPlayerSound.controls.stop();
            mediaPlayerSound.URL = URL_StartGame;
            mediaPlayerSound.controls.play();
        }
        /// <summary>
        /// Phátâm thanh ăn cờ
        /// </summary>
        static public void PlayEatChess()
        {
            if (!IsPlaySound)
            {
                return;
            }
            mediaPlayerSound.controls.stop();
            mediaPlayerSound.URL = URL_EatChess;
            mediaPlayerSound.controls.play();
        }
        /// <summary>
        /// Phát âm thanh di chuyển cờ
        /// </summary>
        static public void PlayMoveChess()
        {
            if (!IsPlaySound)
            {
                return;
            }
            mediaPlayerSound.controls.stop();
            mediaPlayerSound.URL = URL_MoveChess;
            mediaPlayerSound.controls.play();
        }
        /// <summary>
        ///  Phát âm thanh lỗi chiếu tướng
        /// </summary>
        static public void PlayErrorCheckmate()
        {
            if (!IsPlaySound)
            {
                return;
            }
            mediaPlayerSound.controls.stop();
            mediaPlayerSound.URL = URL_Error;
            mediaPlayerSound.controls.play();

        }
        /// <summary>
        /// Phát âm thanh click button
        /// </summary>
        static public void PlayClick()
        {
            if (!IsPlaySound)
            {
                return;
            }
            mediaPlayerSound.controls.stop();
            mediaPlayerSound.URL = URL_Button;
            mediaPlayerSound.controls.play();

        }
        /// <summary>
        /// Phát âm thanh kết thúc ván chơi
        /// </summary>
        static public void PlayWin()
        {
            if (!IsPlaySound)
            {
                return;
            }
            mediaPlayerSound.controls.stop();
            mediaPlayerSound.URL = URL_Win;
            mediaPlayerSound.controls.play();

        }
        /// <summary>
        /// phát âm thanh thua cuộc
        /// </summary>
        static public void PlayLose()
        {
            if (!IsPlaySound)
            {
                return;
            }
            mediaPlayerSound.controls.stop();
            mediaPlayerSound.URL = URL_Lose;
            mediaPlayerSound.controls.play();

        }
        #endregion
    }
}
