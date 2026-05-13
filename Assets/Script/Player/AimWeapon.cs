using UnityEngine;

public class AimWeapon : MonoBehaviour
{
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        HandleAiming();
    }

    private void HandleAiming()
    {
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        mousePosition.z = 0f;

        Vector3 aimDirection = (mousePosition - transform.position).normalized;

        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}