using CommunityToolkit.Mvvm.ComponentModel;
using JoKenPo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private int _score;

        [ObservableProperty]
        private string _playerImage;

        [ObservableProperty]
        private string _enemyImage;

        [ObservableProperty]
        private string _result;

        [ObservableProperty]
        private Choice _playerChoice;

        Player player = new Player();

        public void Play()
        {
            Player enemy = new Player();
            enemy.MakeChoice();
            player.Choice = PlayerChoice;
            if (enemy.Choice == player.Choice)
            {
                Result = "Empatou";
            }
        }

        public GameViewModel() {
            
        }
    }
}
