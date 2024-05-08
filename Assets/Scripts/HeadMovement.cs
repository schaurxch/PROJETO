using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovement: MonoBehaviour
{
    // Sensibilidade do mouse
    public float mouseSensitivity = 100f;

    // Refer�ncia ao transform do jogador
    public Transform playerBody;

    // Rota��o vertical da c�mera
    float xRotation = 0f;

    void Start()
    {
        // Travar o cursor no centro da tela
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Capturar o movimento do mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rota��o vertical da c�mera
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Aplicar a rota��o da c�mera
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotacionar o jogador horizontalmente
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
