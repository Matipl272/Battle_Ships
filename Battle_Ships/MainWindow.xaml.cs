using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Battle_Ships
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        #region Variables


        #endregion

        
        
        #region PriavteMembers;

        //Holds the current result of cell in game
        private MarkType[] mResults;


        //True if Player 1 Turn
        private bool mPlayerTurn;

        //True if game ended
        private bool mGameEnd;


        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        #endregion



        private void NewGame()
        {
            //Create a new array for cells
            mResults = new MarkType[100];

            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;


            //Make sure that 1st player is player 1
            mPlayerTurn = true;

            //MainGrid.Children.Cast<Button>().ToList.foreach

        }


    }
}
