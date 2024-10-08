using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof(ThirdPersonCharacter))]
    public class MultiPlayerUserControl : MonoBehaviour
    {
        private ThirdPersonCharacter m_Character;
        public BallController ballController;

        private void Start()
        {
            m_Character = GetComponent<ThirdPersonCharacter>();
        }

        private void FixedUpdate()
        {
            m_Character.Move(ballController.movementInput, false, false); // No salto ni crouch
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            ballController.OnMove(context);
        }
    }
}



