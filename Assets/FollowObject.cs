using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MainManager;
using UnityEngine.EventSystems;

public class FollowObject : MonoBehaviour, IPointerExitHandler, IPointerClickHandler
{
    private RectTransform rect;
    private Rigidbody2D rb;

    private bool isRight = false;
    private bool isLeft = false;
    private bool isTop = false;
    private bool isBottom = false;
    private float cooldown = 0;

    private float minCooldown = 1f;
    private float maxCooldown = 1f;

    // Start is called before the first frame update
    private void Start()
    {
        rect = GetComponent<RectTransform>();
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine("RandomMove");
    }

    // Update is called once per frame
    private void Update()
    {
        if (rect.localPosition.x >= 900)
        {
            isRight = true;
        }
        else
        {
            isRight = false;
        }

        if (rect.localPosition.x <= -900)
        {
            isLeft = true;
        }
        else
        {
            isLeft = false;
        }

        if (rect.localPosition.y >= 480)
        {
            isTop = true;
        }
        else
        {
            isTop = false;
        }

        if (rect.localPosition.y <= -480)
        {
            isBottom = true;
        }
        else
        {
            isBottom = false;
        }

        if (isRight || isLeft || isTop || isBottom)
        {
            Move();
            cooldown = Random.Range(minCooldown, maxCooldown);
        }
    }

    private IEnumerator RandomMove()
    {
        while (true)
        {
            if (main.isGameStart)
            {
                Move();
                cooldown = Random.Range(minCooldown, maxCooldown);
                yield return new WaitForSeconds(cooldown);
            }
            else
            {
                yield return null;
            }
        }
    }

    private void Move()
    {
        float speed = 400;
        float x = Random.Range(-1000, 1000);
        float y = Random.Range(-1000, 1000);
        // Debug.Log("x" + x);
        // Debug.Log("y" + y);
        if (isRight)
            x = Mathf.Abs(x) * -1;
        if (isLeft)
            x = Mathf.Abs(x);
        if (isTop)
            y = Mathf.Abs(y) * -1;
        if (isBottom)
            y = Mathf.Abs(y);
        //  Debug.Log("x" + x);
        //  Debug.Log("y" + y);
        Vector2 dir = new Vector2(x, y).normalized;

        rb.velocity = dir * speed;
        // Debug.Log(rb.velocity);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        main.GameStart();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!main.isGameStart) return;
        main.GameOver();
    }
}