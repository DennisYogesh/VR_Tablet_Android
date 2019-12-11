using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    GameObject mainMenu;
    public GameObject trackerCamera;

    //public GameObject handPrefab;


    //Methode um Serververbindung aufzubauen
    public void Connect()
    {
        Debug.Log("Connect wird ausgeführt!");
        //Befehl für die Verbindung zum Photon-Network
        PhotonNetwork.ConnectUsingSettings("v1");
    }

    private void OnConnectedToMaster()
    {
        Debug.Log("Mit Master verbunden. Szene für Lobby laden.");
        PhotonNetwork.JoinLobby();
    }

    private void OnJoinedLobby()
    {
        Debug.Log("Mit Lobby verbunden");
        mainMenu.SetActive(false);
        //Zufälligen Raum betreten
        PhotonNetwork.JoinRoom("VR");
    }

    //private void OnPhotonRandomJoinFailed()
    //{
    //    PhotonNetwork.CreateRoom(null);   
    //}

    private void OnJoinedRoom()
    {
        //Spawn ausführen
        Spawn();

    }

    void Spawn()
    {


    }
    void Start()
    {
        
        mainMenu = GameObject.Find("MainMenu");

        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(PhotonNetwork.connectionStateDetailed.ToString());

        //Ausgabe Anzahl weiterer Spieler im Raum
        Debug.Log("Anzahl weiterer Spieler: " + PhotonNetwork.otherPlayers.Length);
    }
}
