using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace Musica
{
    public partial class Home : Form
    {
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        List<string> strList = new List<string>() { @"U:\Music\8 Graves - Bones.mp3", @"U:\Music\A Day To Remember - Resentment.mp3" };
        int i;

        public Home()
        {
            InitializeComponent();
        }

        private int play(int i)
        {
            i = 0;
            wplayer.URL = strList[i];
            wplayer.controls.play();
            playButton.Visible = false;
            pauseButton.Visible = true;
            return i;
        }

        private void pause()
        {
            wplayer.controls.pause();
            playButton.Visible = true;
            pauseButton.Visible = false;
        }

        private int next(int i)
        {
            i++;
            wplayer.URL = strList[i];
            wplayer.controls.next();
            bunifuSlider1.Value = 0;
            return i;
        }

        private int prev(int i)
        {
            i--;
            wplayer.URL = strList[i];
            wplayer.controls.previous();
            bunifuSlider1.Value = 0;
            return i;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            play(i);
        }
        private void PauseButton_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            next(i);
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            prev(i);
        }


        private void Home_Load(object sender, EventArgs e)
        {
            homeSelected();
        }

        private void BrowseClick(object sender, EventArgs e)
        {
            browseSelected();
        }

        private void HomeClick(object sender, EventArgs e)
        {
            homeSelected();
        }

        private void PlaylistClick(object sender, EventArgs e)
        {
            playlistSelected();
        }

        private void AlbumClick(object sender, EventArgs e)
        {
            browseSelected();
        }

        private void ArtistsClick(object sender, EventArgs e)
        {
            browseSelected();
        }

        void browseSelected()
        {
            browseIcon.Image = Properties.Resources.browse_green;
            HomeIcon.Image = Properties.Resources.home_notfilled;
            ArtistIcon.Image = Properties.Resources.artist_notFilled;
            AlbumIcon.Image = Properties.Resources.albums_notfilled;
            playlistIcon.Image = Properties.Resources.playlist_notfilled;
            homeButton.Textcolor = Color.White;
            playlistButton.Textcolor = Color.White;
            AlbumButton.Textcolor = Color.White;
            ArtistsButton.Textcolor = Color.White;
            browseButton.Textcolor = Color.SeaGreen;
            browsePanel.Visible = true;
            HomePanel.Visible = false;
            playlistPagePanel.Visible = false;
        }

        void homeSelected()
        {
            HomeIcon.Image = Properties.Resources.home_green;
            browseIcon.Image = Properties.Resources.browse_notfilled;
            ArtistIcon.Image = Properties.Resources.artist_notFilled;
            playlistIcon.Image = Properties.Resources.playlist_notfilled;
            AlbumIcon.Image = Properties.Resources.albums_notfilled;
            browseButton.Textcolor = Color.White;
            playlistButton.Textcolor = Color.White;
            AlbumButton.Textcolor = Color.White;
            ArtistsButton.Textcolor = Color.White;
            homeButton.Textcolor = Color.SeaGreen;
            HomePanel.Visible = true;
            browsePanel.Visible = false;
            playlistPagePanel.Visible = false;
        }

        void playlistSelected()
        {
            playlistIcon.Image = Properties.Resources.playlist_green;
            browseIcon.Image = Properties.Resources.browse_notfilled;
            ArtistIcon.Image = Properties.Resources.artist_notFilled;
            AlbumIcon.Image = Properties.Resources.albums_notfilled;
            HomeIcon.Image = Properties.Resources.home_notfilled;
            browseButton.Textcolor = Color.White;
            playlistButton.Textcolor = Color.SeaGreen;
            AlbumButton.Textcolor = Color.White;
            ArtistsButton.Textcolor = Color.White;
            homeButton.Textcolor = Color.White;
            playlistPagePanel.Visible = true;
            browsePanel.Visible = false;
            HomePanel.Visible = false;
        }

        private void BunifuSlider2_ValueChanged(object sender, EventArgs e)
        {
            wplayer.settings.volume = bunifuSlider2.Value;
        }

        private void BunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            wplayer.controls.currentPosition = bunifuSlider1.Value;
        }
    }
}
