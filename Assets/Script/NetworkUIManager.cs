using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkUIManager : MonoBehaviour
{
    public Button hostButton;
    public Button clientButton;
    public Button serverButton;
    public Button ExitButton; // �����͡�ҡ��
    public GameObject title;
    public GameObject playMode;
    public GameObject Spawner;
    public GameObject Ground;

    void Start()
    {
        hostButton.onClick.AddListener(StartHost);
        clientButton.onClick.AddListener(StartClient);
        serverButton.onClick.AddListener(StartServer);
        ExitButton.onClick.AddListener(ExitGame); // ���� Listener ����Ѻ���� Exit
    }

    void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        playModeStart();
        HideText();
        HideButtons();
    }

    void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        playModeStart();
        HideText();
        HideButtons();
    }

    void StartServer()
    {
        NetworkManager.Singleton.StartServer();
        playModeStart();
        HideText();
        HideButtons();
    }

    void HideButtons()
    {
        hostButton.gameObject.SetActive(false);
        clientButton.gameObject.SetActive(false);
        serverButton.gameObject.SetActive(false);
        ExitButton.gameObject.SetActive(false); // ��͹���� Exit ����
    }

    void HideText()
    {
        title.gameObject.SetActive(false);
    }

    void playModeStart()
    {
        playMode.gameObject.SetActive(true);
        Spawner.gameObject.SetActive(true);
        Ground.gameObject.SetActive(true);
    }

    void ExitGame()
    {
        // �Դ���͢��¶���ա�÷ӧҹ����
        if (NetworkManager.Singleton != null)
        {
            NetworkManager.Singleton.Shutdown();
            Debug.Log("Network shut down.");
        }

        // �͡�ҡ��
        Debug.Log("Exiting game...");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // ��ش Play Mode � Unity Editor
#else
        Application.Quit(); // �Դ�ͻ���पѹ� Build ��ԧ
#endif
    }
}
