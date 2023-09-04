#if UNITY_EDITOR
using BornCore.Scene;
using UnityEngine;

namespace Born.Maji.Player
{
    public class PlayerMovement : SceneBehaviour
    {
        private float moveSpeed =6f;

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
            transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
#endif