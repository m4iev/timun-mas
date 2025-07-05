using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManagerS4 : MonoBehaviour {

	public Image box;
	public TextMeshProUGUI namaKarakter;
	public TextMeshProUGUI dialogKarakter;
	public AudioSource sound1, sound2;
	public Animator animator;

	private Queue<string> kalimat;

	// Use this for initialization
	void Start () {
		kalimat = new Queue<string>();
	}

	public void StartDialog (Dialog dialog)
	{
		box.enabled = true;
		namaKarakter.enabled = true;
		dialogKarakter.enabled = true;
        animator.SetBool("IsOpen", true);

        namaKarakter.text = dialog.karakter;

        kalimat.Clear();

        foreach (string kata in dialog.kalimat)
        {
            kalimat.Enqueue(kata);
        }

        KalimatBerikutnya();

	}

	public void KalimatBerikutnya ()
	{
		sound1.Stop();
		sound2.Stop();
		
		if (kalimat.Count == 0)
		{
			box.enabled = false;
			namaKarakter.enabled = false;
			dialogKarakter.enabled = false;
			return;
		}

		if (kalimat.Count == 2)
		{
			sound1.Play();
		}

		if (kalimat.Count == 1)
		{
			sound2.Play();
			namaKarakter.text = "Mbok Sirni";
		}

		string sentence = kalimat.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		dialogKarakter.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogKarakter.text += letter;
			yield return new WaitForSeconds(0.03f);
		}
	}


}