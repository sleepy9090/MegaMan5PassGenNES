/**
 *  @file           Form1.cs / FormMegaMan5PassGenNES
 *  @brief          Password Generator for the Nintendo Game MegaMan V.
 *  @copyright      Shawn M. Crawford 2019
 *  @date           04/22/2019
 *
 *  @remark Author  Shawn M. Crawford (sleepy9090)
 *
 *  @note           N/A
 *
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MegaMan5PassGenNES
{
    public partial class FormMegaMan5PassGenNes : Form
    {
        private readonly Bitmap _blankBitmap = MegaMan5PassGenNES.Properties.Resources.blank;
        private readonly Bitmap _redDotBitmap = MegaMan5PassGenNES.Properties.Resources.reddot;
        private readonly Bitmap _blueDotBitmap = MegaMan5PassGenNES.Properties.Resources.bluedot;

        public FormMegaMan5PassGenNes()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;


            PopulateImages();
        }

        private void PopulateImages()
        {
            pictureBoxA1.Image = _blankBitmap;
            pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA1.Image.Tag = _blankBitmap.ToString();
            pictureBoxA2.Image = _blankBitmap;
            pictureBoxA2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA2.Image.Tag = _blankBitmap.ToString();
            pictureBoxA3.Image = _blankBitmap;
            pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA3.Image.Tag = _blankBitmap.ToString();
            pictureBoxA4.Image = _blankBitmap;
            pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA4.Image.Tag = _blankBitmap.ToString();
            pictureBoxA5.Image = _blankBitmap;
            pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA5.Image.Tag = _blankBitmap.ToString();
            pictureBoxA6.Image = _blankBitmap;
            pictureBoxA6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA6.Image.Tag = _blankBitmap.ToString();

            pictureBoxB1.Image = _blankBitmap;
            pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB1.Image.Tag = _blankBitmap.ToString();
            pictureBoxB2.Image = _blankBitmap;
            pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB2.Image.Tag = _blankBitmap.ToString();
            pictureBoxB3.Image = _blankBitmap;
            pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB3.Image.Tag = _blankBitmap.ToString();
            pictureBoxB4.Image = _blankBitmap;
            pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB4.Image.Tag = _blankBitmap.ToString();
            pictureBoxB5.Image = _blankBitmap;
            pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB5.Image.Tag = _blankBitmap.ToString();
            pictureBoxB6.Image = _blankBitmap;
            pictureBoxB6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB6.Image.Tag = _blankBitmap.ToString();

            pictureBoxC1.Image = _blankBitmap;
            pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC1.Image.Tag = _blankBitmap.ToString();
            pictureBoxC2.Image = _blankBitmap;
            pictureBoxC2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC2.Image.Tag = _blankBitmap.ToString();
            pictureBoxC3.Image = _blankBitmap;
            pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC3.Image.Tag = _blankBitmap.ToString();
            pictureBoxC4.Image = _blankBitmap;
            pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC4.Image.Tag = _blankBitmap.ToString();
            pictureBoxC5.Image = _blankBitmap;
            pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC5.Image.Tag = _blankBitmap.ToString();
            pictureBoxC6.Image = _blankBitmap;
            pictureBoxC6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC6.Image.Tag = _blankBitmap.ToString();

            pictureBoxD1.Image = _blankBitmap;
            pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD1.Image.Tag = _blankBitmap.ToString();
            pictureBoxD2.Image = _blankBitmap;
            pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD2.Image.Tag = _blankBitmap.ToString();
            pictureBoxD3.Image = _blankBitmap;
            pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD3.Image.Tag = _blankBitmap.ToString();
            pictureBoxD4.Image = _blankBitmap;
            pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD4.Image.Tag = _blankBitmap.ToString();
            pictureBoxD5.Image = _blankBitmap;
            pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD5.Image.Tag = _blankBitmap.ToString();
            pictureBoxD6.Image = _blankBitmap;
            pictureBoxD6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD6.Image.Tag = _blankBitmap.ToString();

            pictureBoxE1.Image = _blankBitmap;
            pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE1.Image.Tag = _blankBitmap.ToString();
            pictureBoxE2.Image = _blankBitmap;
            pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE2.Image.Tag = _blankBitmap.ToString();
            pictureBoxE3.Image = _blankBitmap;
            pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE3.Image.Tag = _blankBitmap.ToString();
            pictureBoxE4.Image = _blankBitmap;
            pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE4.Image.Tag = _blankBitmap.ToString();
            pictureBoxE5.Image = _blankBitmap;
            pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE5.Image.Tag = _blankBitmap.ToString();
            pictureBoxE6.Image = _blankBitmap;
            pictureBoxE6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE6.Image.Tag = _blankBitmap.ToString();

            pictureBoxF1.Image = _blankBitmap;
            pictureBoxF1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF1.Image.Tag = _blankBitmap.ToString();
            pictureBoxF2.Image = _blankBitmap;
            pictureBoxF2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF2.Image.Tag = _blankBitmap.ToString();
            pictureBoxF3.Image = _blankBitmap;
            pictureBoxF3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF3.Image.Tag = _blankBitmap.ToString();
            pictureBoxF4.Image = _blankBitmap;
            pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF4.Image.Tag = _blankBitmap.ToString();
            pictureBoxF5.Image = _blankBitmap;
            pictureBoxF5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF5.Image.Tag = _blankBitmap.ToString();
            pictureBoxF6.Image = _blankBitmap;
            pictureBoxF6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF6.Image.Tag = _blankBitmap.ToString();
        }

        private void ResetImages()
        {
            pictureBoxA1.Image = null;
            pictureBoxA1.Image = _blankBitmap;
            pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA1.Image.Tag = _blankBitmap.ToString();
            pictureBoxA2.Image = null;
            pictureBoxA2.Image = _blankBitmap;
            pictureBoxA2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA2.Image.Tag = _blankBitmap.ToString();
            pictureBoxA3.Image = null;
            pictureBoxA3.Image = _blankBitmap;
            pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA3.Image.Tag = _blankBitmap.ToString();
            pictureBoxA4.Image = null;
            pictureBoxA4.Image = _blankBitmap;
            pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA4.Image.Tag = _blankBitmap.ToString();
            pictureBoxA5.Image = null;
            pictureBoxA5.Image = _blankBitmap;
            pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA5.Image.Tag = _blankBitmap.ToString();
            pictureBoxA6.Image = null;
            pictureBoxA6.Image = _blankBitmap;
            pictureBoxA6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA6.Image.Tag = _blankBitmap.ToString();

            pictureBoxB1.Image = null;
            pictureBoxB1.Image = _blankBitmap;
            pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB1.Image.Tag = _blankBitmap.ToString();
            pictureBoxB2.Image = null;
            pictureBoxB2.Image = _blankBitmap;
            pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB2.Image.Tag = _blankBitmap.ToString();
            pictureBoxB3.Image = null;
            pictureBoxB3.Image = _blankBitmap;
            pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB3.Image.Tag = _blankBitmap.ToString();
            pictureBoxB4.Image = null;
            pictureBoxB4.Image = _blankBitmap;
            pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB4.Image.Tag = _blankBitmap.ToString();
            pictureBoxB5.Image = null;
            pictureBoxB5.Image = _blankBitmap;
            pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB5.Image.Tag = _blankBitmap.ToString();
            pictureBoxB6.Image = null;
            pictureBoxB6.Image = _blankBitmap;
            pictureBoxB6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB6.Image.Tag = _blankBitmap.ToString();

            pictureBoxC1.Image = null;
            pictureBoxC1.Image = _blankBitmap;
            pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC1.Image.Tag = _blankBitmap.ToString();
            pictureBoxC2.Image = null;
            pictureBoxC2.Image = _blankBitmap;
            pictureBoxC2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC2.Image.Tag = _blankBitmap.ToString();
            pictureBoxC3.Image = null;
            pictureBoxC3.Image = _blankBitmap;
            pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC3.Image.Tag = _blankBitmap.ToString();
            pictureBoxC4.Image = null;
            pictureBoxC4.Image = _blankBitmap;
            pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC4.Image.Tag = _blankBitmap.ToString();
            pictureBoxC5.Image = null;
            pictureBoxC5.Image = _blankBitmap;
            pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC5.Image.Tag = _blankBitmap.ToString();
            pictureBoxC6.Image = null;
            pictureBoxC6.Image = _blankBitmap;
            pictureBoxC6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC6.Image.Tag = _blankBitmap.ToString();

            pictureBoxD1.Image = null;
            pictureBoxD1.Image = _blankBitmap;
            pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD1.Image.Tag = _blankBitmap.ToString();
            pictureBoxD2.Image = null;
            pictureBoxD2.Image = _blankBitmap;
            pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD2.Image.Tag = _blankBitmap.ToString();
            pictureBoxD3.Image = null;
            pictureBoxD3.Image = _blankBitmap;
            pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD3.Image.Tag = _blankBitmap.ToString();
            pictureBoxD4.Image = null;
            pictureBoxD4.Image = _blankBitmap;
            pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD4.Image.Tag = _blankBitmap.ToString();
            pictureBoxD5.Image = null;
            pictureBoxD5.Image = _blankBitmap;
            pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD5.Image.Tag = _blankBitmap.ToString();
            pictureBoxD6.Image = null;
            pictureBoxD6.Image = _blankBitmap;
            pictureBoxD6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD6.Image.Tag = _blankBitmap.ToString();

            pictureBoxE1.Image = null;
            pictureBoxE1.Image = _blankBitmap;
            pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE1.Image.Tag = _blankBitmap.ToString();
            pictureBoxE2.Image = null;
            pictureBoxE2.Image = _blankBitmap;
            pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE2.Image.Tag = _blankBitmap.ToString();
            pictureBoxE3.Image = null;
            pictureBoxE3.Image = _blankBitmap;
            pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE3.Image.Tag = _blankBitmap.ToString();
            pictureBoxE4.Image = null;
            pictureBoxE4.Image = _blankBitmap;
            pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE4.Image.Tag = _blankBitmap.ToString();
            pictureBoxE5.Image = null;
            pictureBoxE5.Image = _blankBitmap;
            pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE5.Image.Tag = _blankBitmap.ToString();
            pictureBoxE6.Image = null;
            pictureBoxE6.Image = _blankBitmap;
            pictureBoxE6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE6.Image.Tag = _blankBitmap.ToString();

            pictureBoxF1.Image = null;
            pictureBoxF1.Image = _blankBitmap;
            pictureBoxF1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF1.Image.Tag = _blankBitmap.ToString();
            pictureBoxF2.Image = null;
            pictureBoxF2.Image = _blankBitmap;
            pictureBoxF2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF2.Image.Tag = _blankBitmap.ToString();
            pictureBoxF3.Image = null;
            pictureBoxF3.Image = _blankBitmap;
            pictureBoxF3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF3.Image.Tag = _blankBitmap.ToString();
            pictureBoxF4.Image = null;
            pictureBoxF4.Image = _blankBitmap;
            pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF4.Image.Tag = _blankBitmap.ToString();
            pictureBoxF5.Image = null;
            pictureBoxF5.Image = _blankBitmap;
            pictureBoxF5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF5.Image.Tag = _blankBitmap.ToString();
            pictureBoxF6.Image = null;
            pictureBoxF6.Image = _blankBitmap;
            pictureBoxF6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF6.Image.Tag = _blankBitmap.ToString();
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ResetImages();

            #region variables
            bool hasPowerStone = checkBoxPowerStone.Checked;
            bool hasGravityHold = checkBoxGravityHold.Checked;
            bool hasNapalmBomb = checkBoxNapalmBomb.Checked;
            bool hasChargeKick = checkBoxChargeKick.Checked;
            bool hasGyroAttack = checkBoxGyroAttack.Checked;
            bool hasWaterWave = checkBoxWaterWave.Checked;
            bool hasStarCrash = checkBoxStarCrash.Checked;
            bool hasCrystalEye = checkBoxCrystalEye.Checked;

            bool hasMPlate = checkBoxMPlate.Checked;
            bool hasEPlate = checkBoxEPlate.Checked;
            bool hasGPlate = checkBoxGPlate.Checked;
            bool hasAPlate = checkBoxAPlate.Checked;
            bool hasMPlate2 = checkBoxMPlate2.Checked;
            bool hasAPlate2 = checkBoxAPlate2.Checked;
            bool hasNPlate = checkBoxNPlate.Checked;
            bool hasVPlate = checkBoxVPlate.Checked;
            #endregion

            #region NapalmMan and CrystalMan
            if (hasNapalmBomb && hasCrystalEye)
            {
                pictureBoxC1.Image = null;
                pictureBoxC1.Image = _redDotBitmap;
                pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxC1.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasNapalmBomb)
            {
                pictureBoxE2.Image = null;
                pictureBoxE2.Image = _redDotBitmap;
                pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxE2.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasCrystalEye)
            {
                pictureBoxD2.Image = null;
                pictureBoxD2.Image = _redDotBitmap;
                pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxD2.Image.Tag = _redDotBitmap.ToString();
            }
            else
            {
                pictureBoxB1.Image = null;
                pictureBoxB1.Image = _redDotBitmap;
                pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxB1.Image.Tag = _redDotBitmap.ToString();
            }
            #endregion

            #region GyroMan, CrashMan, and ChargeMan
            if (hasGyroAttack && hasStarCrash && hasChargeKick)
            {
                pictureBoxD4.Image = null;
                pictureBoxD4.Image = _redDotBitmap;
                pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxD4.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasGyroAttack && hasStarCrash)
            {
                pictureBoxE3.Image = null;
                pictureBoxE3.Image = _redDotBitmap;
                pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxE3.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasStarCrash && hasChargeKick)
            {
                pictureBoxA3.Image = null;
                pictureBoxA3.Image = _redDotBitmap;
                pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxA3.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasGyroAttack && hasChargeKick)
            {
                pictureBoxE4.Image = null;
                pictureBoxE4.Image = _redDotBitmap;
                pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxE4.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasGyroAttack)
            {
                pictureBoxA4.Image = null;
                pictureBoxA4.Image = _redDotBitmap;
                pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxA4.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasStarCrash)
            {
                pictureBoxF4.Image = null;
                pictureBoxF4.Image = _redDotBitmap;
                pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxF4.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasChargeKick)
            {
                pictureBoxF3.Image = null;
                pictureBoxF3.Image = _redDotBitmap;
                pictureBoxF3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxF3.Image.Tag = _redDotBitmap.ToString();
            }
            else
            {
                pictureBoxD3.Image = null;
                pictureBoxD3.Image = _redDotBitmap;
                pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxD3.Image.Tag = _redDotBitmap.ToString();
            }
            #endregion

            #region GravityMan, WaveMan, and StoneMan
            if (hasGravityHold && hasWaterWave && hasPowerStone)
            {
                pictureBoxF6.Image = null;
                pictureBoxF6.Image = _redDotBitmap;
                pictureBoxF6.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxF6.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasGravityHold && hasWaterWave)
            {
                pictureBoxA5.Image = null;
                pictureBoxA5.Image = _redDotBitmap;
                pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxA5.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasWaterWave && hasPowerStone)
            {
                pictureBoxC5.Image = null;
                pictureBoxC5.Image = _redDotBitmap;
                pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxC5.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasGravityHold && hasPowerStone)
            {
                pictureBoxA6.Image = null;
                pictureBoxA6.Image = _redDotBitmap;
                pictureBoxA6.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxA6.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasGravityHold)
            {
                pictureBoxC6.Image = null;
                pictureBoxC6.Image = _redDotBitmap;
                pictureBoxC6.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxC6.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasWaterWave)
            {
                pictureBoxB6.Image = null;
                pictureBoxB6.Image = _redDotBitmap;
                pictureBoxB6.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxB6.Image.Tag = _redDotBitmap.ToString();
            }
            else if (hasPowerStone)
            {
                pictureBoxB5.Image = null;
                pictureBoxB5.Image = _redDotBitmap;
                pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxB5.Image.Tag = _redDotBitmap.ToString();
            }
            else
            {
                pictureBoxF5.Image = null;
                pictureBoxF5.Image = _redDotBitmap;
                pictureBoxF5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxF5.Image.Tag = _redDotBitmap.ToString();
            }
            #endregion

            #region Nplate and Vplate
            if (hasNPlate && hasVPlate)
            {
                if (!Object.Equals(pictureBoxC1.Image, _blankBitmap))
                {
                    pictureBoxF1.Image = null;
                    pictureBoxF1.Image = _blueDotBitmap;
                    pictureBoxF1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxF1.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxC1.Image = null;
                    pictureBoxC1.Image = _blueDotBitmap;
                    pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC1.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasNPlate)
            {
                if (!Object.Equals(pictureBoxE2.Image, _blankBitmap))
                {
                    pictureBoxA2.Image = null;
                    pictureBoxA2.Image = _blueDotBitmap;
                    pictureBoxA2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA2.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxE2.Image = null;
                    pictureBoxE2.Image = _blueDotBitmap;
                    pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxE2.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasVPlate)
            {
                if (!Object.Equals(pictureBoxD2.Image, _blankBitmap))
                {
                    pictureBoxA2.Image = null;
                    pictureBoxA2.Image = _blueDotBitmap;
                    pictureBoxA2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA2.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxD2.Image = null;
                    pictureBoxD2.Image = _blueDotBitmap;
                    pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD2.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else
            {
                if (!Object.Equals(pictureBoxB1.Image, _blankBitmap))
                {
                    pictureBoxF1.Image = null;
                    pictureBoxF1.Image = _blueDotBitmap;
                    pictureBoxF1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxF1.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxB1.Image = null;
                    pictureBoxB1.Image = _blueDotBitmap;
                    pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxB1.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            #endregion

            #region Aplate (GyroMan), Mplate2 (StarMan), and Aplate2 (ChargeMan)
            if (hasAPlate && hasMPlate2 && hasAPlate2)
            {
                if (!Object.Equals(pictureBoxD4.Image, _blankBitmap))
                {
                    pictureBoxB4.Image = null;
                    pictureBoxB4.Image = _blueDotBitmap;
                    pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxB4.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxD4.Image = null;
                    pictureBoxD4.Image = _blueDotBitmap;
                    pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD4.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasAPlate && hasMPlate2)
            {
                if (!Object.Equals(pictureBoxE3.Image, _blankBitmap))
                {
                    pictureBoxB3.Image = null;
                    pictureBoxB3.Image = _blueDotBitmap;
                    pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxB3.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxE3.Image = null;
                    pictureBoxE3.Image = _blueDotBitmap;
                    pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxE3.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasMPlate2 && hasAPlate2)
            {
                if (!Object.Equals(pictureBoxA3.Image, _blankBitmap))
                {
                    pictureBoxC3.Image = null;
                    pictureBoxC3.Image = _blueDotBitmap;
                    pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC3.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxA3.Image = null;
                    pictureBoxA3.Image = _blueDotBitmap;
                    pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA3.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasAPlate && hasAPlate2)
            {
                if (!Object.Equals(pictureBoxE4.Image, _blankBitmap))
                {
                    pictureBoxB4.Image = null;
                    pictureBoxB4.Image = _blueDotBitmap;
                    pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxB4.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxE4.Image = null;
                    pictureBoxE4.Image = _blueDotBitmap;
                    pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxE4.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasAPlate)
            {
                if (!Object.Equals(pictureBoxA4.Image, _blankBitmap))
                {
                    pictureBoxC4.Image = null;
                    pictureBoxC4.Image = _blueDotBitmap;
                    pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC4.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxA4.Image = null;
                    pictureBoxA4.Image = _blueDotBitmap;
                    pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA4.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasMPlate2)
            {
                if (!Object.Equals(pictureBoxF4.Image, _blankBitmap))
                {
                    pictureBoxC4.Image = null;
                    pictureBoxC4.Image = _blueDotBitmap;
                    pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD4.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxF4.Image = null;
                    pictureBoxF4.Image = _blueDotBitmap;
                    pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxF4.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasAPlate2)
            {
                if (!Object.Equals(pictureBoxF3.Image, _blankBitmap))
                {
                    pictureBoxC3.Image = null;
                    pictureBoxC3.Image = _blueDotBitmap;
                    pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC3.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxF3.Image = null;
                    pictureBoxF3.Image = _blueDotBitmap;
                    pictureBoxF3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxF3.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else
            {
                if (!Object.Equals(pictureBoxD3.Image, _blankBitmap))
                {
                    pictureBoxB3.Image = null;
                    pictureBoxB3.Image = _blueDotBitmap;
                    pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxB3.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxD3.Image = null;
                    pictureBoxD3.Image = _blueDotBitmap;
                    pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD3.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            #endregion

            #region Mplate (GravityMan), Eplate, and Gplate
            if (hasMPlate && hasEPlate && hasGPlate)
            {
                if (!Object.Equals(pictureBoxF6.Image, _blankBitmap))
                {
                    pictureBoxD6.Image = null;
                    pictureBoxD6.Image = _blueDotBitmap;
                    pictureBoxD6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD6.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxF6.Image = null;
                    pictureBoxF6.Image = _blueDotBitmap;
                    pictureBoxF6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxF6.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasMPlate && hasEPlate)
            {
                if (!Object.Equals(pictureBoxA5.Image, _blankBitmap))
                {
                    pictureBoxE5.Image = null;
                    pictureBoxE5.Image = _blueDotBitmap;
                    pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxE5.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxA5.Image = null;
                    pictureBoxA5.Image = _blueDotBitmap;
                    pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA5.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasEPlate && hasGPlate)
            {
                if (!Object.Equals(pictureBoxC5.Image, _blankBitmap))
                {
                    pictureBoxD5.Image = null;
                    pictureBoxD5.Image = _blueDotBitmap;
                    pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD5.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxC5.Image = null;
                    pictureBoxC5.Image = _blueDotBitmap;
                    pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC5.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasMPlate && hasGPlate)
            {
                if (!Object.Equals(pictureBoxA6.Image, _blankBitmap))
                {
                    pictureBoxD6.Image = null;
                    pictureBoxD6.Image = _blueDotBitmap;
                    pictureBoxD6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD6.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxA6.Image = null;
                    pictureBoxA6.Image = _blueDotBitmap;
                    pictureBoxA6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA6.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasMPlate)
            {
                if (!Object.Equals(pictureBoxC6.Image, _blankBitmap))
                {
                    pictureBoxE6.Image = null;
                    pictureBoxE6.Image = _blueDotBitmap;
                    pictureBoxE6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxE6.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxC6.Image = null;
                    pictureBoxC6.Image = _blueDotBitmap;
                    pictureBoxC6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC6.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasEPlate)
            {
                if (!Object.Equals(pictureBoxB6.Image, _blankBitmap))
                {
                    pictureBoxE6.Image = null;
                    pictureBoxE6.Image = _blueDotBitmap;
                    pictureBoxE6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxE6.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxB6.Image = null;
                    pictureBoxB6.Image = _blueDotBitmap;
                    pictureBoxB6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxB6.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else if (hasGPlate)
            {
                if (!Object.Equals(pictureBoxB5.Image, _blankBitmap))
                {
                    pictureBoxD5.Image = null;
                    pictureBoxD5.Image = _blueDotBitmap;
                    pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD5.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxB5.Image = null;
                    pictureBoxB5.Image = _blueDotBitmap;
                    pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxB5.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            else
            {
                if (!Object.Equals(pictureBoxF5.Image, _blankBitmap))
                {
                    pictureBoxE5.Image = null;
                    pictureBoxE5.Image = _blueDotBitmap;
                    pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxE5.Image.Tag = _blueDotBitmap.ToString();
                }
                else
                {
                    pictureBoxF5.Image = null;
                    pictureBoxF5.Image = _blueDotBitmap;
                    pictureBoxF5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxF5.Image.Tag = _blueDotBitmap.ToString();
                }
            }
            #endregion
        }
    }
}
