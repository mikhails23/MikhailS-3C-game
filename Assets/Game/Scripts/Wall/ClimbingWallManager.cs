using System;
using UnityEngine;

public class ClimbingWallManager : MonoBehaviour
{
    [SerializeField]
    private InputManager _input;
    [SerializeField]
    private GameObject topCollider;
    [SerializeField]
    private GameObject leftCollider;
    [SerializeField]
    private GameObject rightCollider;

    void Start()
    {
        _input.OnClimbInput += EnableWallCollider;
        _input.OnCancelClimb += DisableWallCollider;
    }

    void OnDestroy()
    {
        _input.OnClimbInput -= EnableWallCollider;
        _input.OnCancelClimb -= DisableWallCollider;
    }
    
    private void EnableWallCollider()
    {
        topCollider.SetActive(true);
        leftCollider.SetActive(true);
        rightCollider.SetActive(true);
    }
    private void DisableWallCollider()
    {
        topCollider.SetActive(false);
        leftCollider.SetActive(false);
        rightCollider.SetActive(false);
    }
}
