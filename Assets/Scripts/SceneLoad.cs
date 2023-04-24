using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoad : MonoBehaviour
{
   public void MainMenu()
   {
      SceneManager.LoadScene(0);
   }

   public void ChessPage()
   {
      SceneManager.LoadScene(1);
   }
   
   public void DeadCellsPage()
   {
      SceneManager.LoadScene(2);
   }
   
   public void DoodleJump()
   {
      SceneManager.LoadScene(3);
   }
   
   public void KingdomRushPage()
   {
      SceneManager.LoadScene(4);
   }
   
   public void CastelvaniaPage()
   {
      SceneManager.LoadScene(5);
   }
   
   public void ThisWarOfMINePage()
   {
      SceneManager.LoadScene(6);
   }
   
   public void ValianHearts()
   {
      SceneManager.LoadScene(7);
   }
   
   public void Stugna()
   {
      SceneManager.LoadScene(8);
   }

}
