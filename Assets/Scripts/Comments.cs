
using UnityEngine;
using UnityEngine.UI;

public class Comments : MonoBehaviour
{
   public InputField comment;
   public Text commentText;


   public void AddComment()
   {
      commentText.text += comment.text;
   }
}
