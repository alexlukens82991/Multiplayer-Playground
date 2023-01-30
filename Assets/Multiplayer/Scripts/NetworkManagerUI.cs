using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{
    [Header("Cache")]
    [SerializeField] private Button m_ServerBtn;
    [SerializeField] private Button m_HostBtn;
    [SerializeField] private Button m_ClientBtn;
    [SerializeField] private CanvasGroup m_Cg;

    private void Awake()
    {
        m_ServerBtn.onClick.AddListener(() => { NetworkManager.Singleton.StartServer(); ClosePanel(); });
        m_HostBtn.onClick.AddListener(() => { NetworkManager.Singleton.StartHost(); ClosePanel(); });
        m_ClientBtn.onClick.AddListener(() => { NetworkManager.Singleton.StartClient(); ClosePanel(); });
    }

    private void ClosePanel()
    {
        m_Cg.alpha = 0;
        m_Cg.interactable = false;
        m_Cg.blocksRaycasts = false;
    }
}
