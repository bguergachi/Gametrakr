﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace GameTrakr.ViewLayer
{
    public sealed partial class GameCardView : UserControl
    {
        private Game currentGame;

        public GameCardView()
        {
            this.InitializeComponent();
        }

        public GameCardView(Game game)
        {
            this.currentGame = game;
            this.InitializeComponent();
        }


        private void updateCard(Game game)
        {
            // TODO: Update all UI with Game obj
            this.TitleLbl.Text = game.name == null ? "---" : game.name;
            if(game.cover != null)
            this.GameCoverImage.Source = new BitmapImage(
                new Uri( "https:"+game.cover["url"], UriKind.RelativeOrAbsolute));;
        }

        private void GameCardView1_Loaded(object sender, RoutedEventArgs e)
        {
            updateCard(currentGame);
        }
    }
}
