using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
   public Ball ball;
   public Paddle PlayerPaddle;
   public Paddle ComputerPaddle;

   public TextMeshProUGUI Player1ScoreText;
   public TextMeshProUGUI Player2ScoreText;
   
   public static int player1Score;
   public static int player2Score;

   public void Player1Scores()
   {
      //Adds +1 to Player1's score
      player1Score++;

      //Displays Player1's score and then resets the round
      this.Player1ScoreText.text = player1Score.ToString();
      ResetRound();
   }

   public void Player2Scores()
   {
      //Adds +1 to Player2's score
      player2Score++;
      
      //Displays Player2's score and then resets the round
      this.Player2ScoreText.text = player2Score.ToString();
      ResetRound();
   }

   private void ResetRound()
   {
      //Resets everything positions
      this.PlayerPaddle.ResetPosition();
      this.ComputerPaddle.ResetPosition();

      this.ball.ResetPosition();
      this.ball.AddStartingForce();

      //I feel like I'm over explaining stuff...
   }
}
