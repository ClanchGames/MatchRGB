/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
public class UIManager : MonoBehaviour
{
    public static UIManager uiManager;

    [SerializeField]
    List<GameObject> SpellUIList = new List<GameObject>();


    [SerializeField]
    GameObject ChooseRewardScreen;

    //選ぶときのエリア
    [SerializeField]
    GameObject ChooseRewardArea;

    //ゲットした後のエリア
    [SerializeField]
    GameObject UISpellArea;


    GameObject CurrentScreen;

    GameObject RewardSpell;

    int chooseNum = 3;

    public bool isPause;


    [SerializeField]
    GameObject TileArea;
    private void Awake()
    {
        if (uiManager == null)
        {
            uiManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) SwitchPause();

        if (TileArea.activeSelf)
        {
            isPause = true;
            Time.timeScale = 0f;
        }
    }

    public void SwitchPause()
    {
        if (!isPause)
        {
            isPause = true;
            Time.timeScale = 0f;
        }
        else
        {
            isPause = false;
            Time.timeScale = 1f;
        }
    }
    public void SwitchTileArea()
    {
        if (TileArea.activeSelf)
        {
            TileArea.SetActive(false);
        }
        else
        {
            TileArea.SetActive(true);
        }
    }
    public void GetSpell(SpellType spellType, Transform transform)
    {
        List<GameObject> BrothersList = transform.GetBrothersAll();
        foreach (var item in BrothersList)
        {
            if (item.tag != Tag.DontDestroy.ToString() && item != transform.gameObject)
            {
                Destroy(item);
            }
        }
        transform.SetParent(UISpellArea.transform, false);
        CloseScreen();
        Destroy(RewardSpell);
    }
    void DestroyRewardUI()
    {
        List<GameObject> Children = ChooseRewardArea.transform.GetChildren();
        foreach (var item in Children)
        {
            if (item.tag != Tag.DontDestroy.ToString())
            {
                Destroy(item);
            }
        }
    }
    public void ChooseRewardSpell(GameObject rewardSpell, bool isTouchFirst)
    {
        OpenScreen(ChooseRewardScreen);
        if (!isTouchFirst) return;
        RewardSpell = rewardSpell;
        List<int> ChosenNum = MyMethod.GetRandomDifferentInt(0, SpellUIList.Count, chooseNum);
        for (int i = 0; i < ChosenNum.Count; i++)
        {
            GameObject spellUI = Instantiate(SpellUIList[ChosenNum[i]]);
            spellUI.transform.SetParent(ChooseRewardArea.transform, false);
            RectTransform rect = spellUI.GetComponent<RectTransform>();
            rect.localPosition = new Vector2(0, 0);
        }


        cancelMethod = () =>
        {
            CloseScreen();
        };
    }
    public void SkipReward()
    {
        DestroyRewardUI();
        if (RewardSpell != null) Destroy(RewardSpell);
    }



    delegate void CloseScreenDelegate();
    CloseScreenDelegate closeScreenDelegate;
    void OpenScreen(GameObject screen)
    {
        screen.SetActive(true);
        closeScreenDelegate = () => { screen.SetActive(false); };
    }
    public void CloseScreen()
    {
        closeScreenDelegate();
    }

    delegate void CancelMethod();
    CancelMethod cancelMethod;
    public void CancelButton()
    {
        cancelMethod();
    }
}
*/