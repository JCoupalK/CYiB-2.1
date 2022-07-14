using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SettingsMenuOptions : MonoBehaviour
{
	public AudioMixer Master;
	public Slider SFX;
	public Slider Music;
	public Dropdown resolutionDropdown;

	public GameObject[] Rain;

	Resolution[] resolutions;


	private void Awake()
	{
		SFX.value = PlayerPrefs.GetInt("sfxSliderNumber");
		Music.value = PlayerPrefs.GetInt("musicSliderNumber");
	}

	private void Start()
	{
		Rain = GameObject.FindGameObjectsWithTag("Rain");

		Master.SetFloat("Volume", PlayerPrefs.GetInt("sfxSliderNumber"));
		Master.SetFloat("Volume", PlayerPrefs.GetInt("musicSliderNumber"));

		resolutions = Screen.resolutions;

		resolutionDropdown.ClearOptions();

		List<string> options = new List<string>();

		int currentResolutionIndex = 0;
		for (int i = 0; i < resolutions.Length; i++)
		{
			string option = resolutions[i].width + " x " + resolutions[i].height;
			options.Add(option);

			if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
			{
				currentResolutionIndex = i;
			}
		}

		resolutionDropdown.AddOptions(options);
		resolutionDropdown.value = currentResolutionIndex;
		resolutionDropdown.RefreshShownValue();
	}

	private void Update()
	{
		PlayerPrefs.SetInt("sfxSliderNumber", (int)SFX.value);
		PlayerPrefs.SetInt("musicSliderNumber", (int)Music.value);
	}

	public void SetResolution (int resolutionIndex)
	{
		Resolution resolution = resolutions[resolutionIndex];
		Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
	}


	public void SetSfxLvl(float sfxLvl)
	{
		Master.SetFloat("sfxVol", sfxLvl);
	}

	public void SetMusicLvl (float musicLvl)
	{
		Master.SetFloat("musicVol", musicLvl);
	}

	

	public void RainToggle()
	{

		GameObject[] Rain = GameObject.FindGameObjectsWithTag("Rain");

		foreach (GameObject go in Rain)
		{
			go.SetActive(false);
		}
	}

	

	public void SetFullscreen (bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
		Debug.Log("FullScreen Activated");
	}
}
