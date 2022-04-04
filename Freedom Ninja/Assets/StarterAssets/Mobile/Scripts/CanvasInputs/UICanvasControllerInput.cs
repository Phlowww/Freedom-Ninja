using UnityEngine;


namespace com.LancasterLakota.FreedomNinja
{
    public class UICanvasControllerInput : MonoBehaviour
    {
       

        [Header("Output")]
        public NinjaController starterAssetsInputs;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            starterAssetsInputs.MoveInput(virtualMoveDirection);
        }


        public void VirtualJumpInput(bool virtualJumpState)
        {
            starterAssetsInputs.JumpInput(virtualJumpState);
        }

        
    }

}
