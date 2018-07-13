/** Управление главным меню. Автор - Максим **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject menu;
	public GameObject levelSel;
    public GameObject startLevel;
	public GameObject settings;
	public GameObject devs;

	// Use this for initialization
	void Start ()
	{
		menu.SetActive(true);
		levelSel.SetActive(false);
        startLevel.SetActive(false);
		settings.SetActive(false);
		devs.SetActive(false);
	}

	public void sceneMenu()                 // Вызывается при нажатии кнопки "Назад". Открывается сцена Главное меню
	{
		menu.SetActive(true);				// Включается сцена Главное меню
		levelSel.SetActive(false);			// Отключается сцена Выбор уровня
		settings.SetActive(false);			// Отключается сцена Настройки
		devs.SetActive(false);				// Отключается сцена Разработчики
	}

	public void sceneLevelSel()				// Вызывается при нажатии кнопки "Новая игра". Открывается сцена Выбор уровня
	{
		levelSel.SetActive(true);           // Включается сцена Выбор уровня
		menu.SetActive(false);              // Отключается сцена Главное меню
        startLevel.SetActive(false);        // Отключается сцена Начать уровень
		settings.SetActive(false);          // Отключается сцена Настройки
		devs.SetActive(false);              // Отключается сцена Разработчики
	}

	public void sceneSettings()				// Вызывается при нажатии кнопки "Настройки". Открывается сцена Настройки
	{
		settings.SetActive(true);           // Включается сцена Настройки
		menu.SetActive(false);              // Отключается сцена Главное меню
		levelSel.SetActive(false);          // Отключается сцена Выбор уровня
		devs.SetActive(false);              // Отключается сцена Разработчики
	}

	public void sceneDevs()                 // Вызывается при нажатии кнопки "Разработчики". Открывается сцена Разработчики
	{
		devs.SetActive(true);				// Включается сцена Разработчики
		menu.SetActive(false);              // Отключается сцена Главное меню
		levelSel.SetActive(false);          // Отключается сцена Выбор уровня
		settings.SetActive(false);          // Отключается сцена Настройки
	}

    public void chooseLevel(int num)        // Выбор уровня
    {
        GameObject.Find("Settings").GetComponent<Settings>().levelNum = num;
        startLevel.SetActive(true);
    }

    public void changeScene(string c)       // Выбор класса и запуск уровня
    {
        Settings sets = GameObject.Find("Settings").GetComponent<Settings>();
        sets.className = c;
        SceneManager.LoadScene(sets.levelNum);
    }
}
