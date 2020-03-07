using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviourPunCallbacks
{
    public GameObject userNameScreen;
    public GameObject connectScreen;

    public Button userNameBtn;
    public InputField userNameInput;

    public Button createRoomBtn;
    public InputField createRoomInput;

    public Button joinRoomBtn;
    public InputField joinRoomInput;
    // Start is called before the first frame update
    void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();
        userNameBtn.onClick.AddListener(OnClickSubmitName);
        createRoomBtn.onClick.AddListener(() => OnClickCreateRoom(createRoomInput.text));
        joinRoomBtn.onClick.AddListener(() => OnClickJoinRoom(joinRoomInput.text));

    }

    private void OnClickJoinRoom(string text)
    {
        throw new NotImplementedException();
    }

    private void OnClickCreateRoom(string text)
    {
        throw new NotImplementedException();
    }

    private void OnClickSubmitName()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
