using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;

    // Update is called once per frame
    void Update()
    {
        // 프레임당 Update 실행. deltatime은 프레임의 주기이자 초당 프레임에 역수를 취한 값.
        // 1초당 rotationSpeed만큼 회전하기 위해 update횟수 * 회전량 * 프레임의 역수
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
