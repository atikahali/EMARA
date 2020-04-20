using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class scanVirtualBtn : MonoBehaviour, IVirtualButtonEventHandler
{

    // Private fields to store the models
    //3D object
    private GameObject injapBikuspid, ventrikelKiri, injapSabit, atriumKiri, venaPulmonari, septum, ventrikelKanan, venaKavaInferior, injapTrikuspid, atriumKanan, injapSabit2, venaKavaSuperior, aorta, arteriPulmonari;

    //virtual button
    private GameObject injapBikuspidVb, ventrikelKiriVb, injapSabitVb, atriumKiriVb, venaPulmonariVb, septumVb, ventrikelKananVb, venaKavaInferiorVb, injapTrikuspidVb, atriumKananVb, injapSabit2Vb, venaKavaSuperiorVb, aortaVb, arteriPulmonariVb;

    // Called when the scene is loaded
    void Start()
    {

        // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }

        injapBikuspid = transform.Find("injapBikuspid").gameObject;
        ventrikelKiri = transform.Find("ventrikelKiri").gameObject;
        injapSabit = transform.Find("injapSabit").gameObject;
        atriumKiri = transform.Find("atriumKiri").gameObject;
        venaPulmonari = transform.Find("venaPulmonari").gameObject;
        septum = transform.Find("septum").gameObject;
        ventrikelKanan = transform.Find("ventrikelKanan").gameObject;
        venaKavaInferior = transform.Find("venaKavaInferior").gameObject;
        injapTrikuspid = transform.Find("injapTrikuspid").gameObject;
        atriumKanan = transform.Find("atriumKanan").gameObject;
        injapSabit2 = transform.Find("injapSabit2").gameObject;
        venaKavaSuperior = transform.Find("venaKavaSuperior").gameObject;
        aorta = transform.Find("aorta").gameObject;
        arteriPulmonari = transform.Find("arteriPulmonari").gameObject;

        injapBikuspidVb = transform.Find("injapBikuspidVb").gameObject;
        ventrikelKiriVb = transform.Find("ventrikelKiriVb").gameObject;
        injapSabitVb = transform.Find("injapSabitVb").gameObject;
        atriumKiriVb = transform.Find("atriumKiriVb").gameObject;
        venaPulmonariVb = transform.Find("venaPulmonariVb").gameObject;
        septumVb = transform.Find("septumVb").gameObject;
        ventrikelKananVb = transform.Find("ventrikelKananVb").gameObject;
        venaKavaInferiorVb = transform.Find("venaKavaInferiorVb").gameObject;
        injapTrikuspidVb = transform.Find("injapTrikuspidVb").gameObject;
        atriumKananVb = transform.Find("atriumKananVb").gameObject;
        injapSabit2Vb = transform.Find("injapSabit2Vb").gameObject;
        venaKavaSuperiorVb = transform.Find("venaKavaSuperiorVb").gameObject;
        aortaVb = transform.Find("aortaVb").gameObject;
        arteriPulmonariVb = transform.Find("arteriPulmonariVb").gameObject;

        // We don't want to show details during the startup
        injapBikuspid.SetActive(false);
        ventrikelKiri.SetActive(false);
        injapSabit.SetActive(false);
        atriumKiri.SetActive(false);
        venaPulmonari.SetActive(false);
        septum.SetActive(false);
        ventrikelKanan.SetActive(false);
        venaKavaInferior.SetActive(false);
        injapTrikuspid.SetActive(false);
        atriumKanan.SetActive(false);
        injapSabit2.SetActive(false);
        venaKavaSuperior.SetActive(false);
        aorta.SetActive(false);
        arteriPulmonari.SetActive(false);

        injapBikuspidVb.SetActive(true);
        ventrikelKiriVb.SetActive(true);
        injapSabitVb.SetActive(true);
        atriumKiriVb.SetActive(true);
        venaPulmonariVb.SetActive(true);
        septumVb.SetActive(true);
        ventrikelKananVb.SetActive(true);
        venaKavaInferiorVb.SetActive(true);
        injapTrikuspidVb.SetActive(true);
        atriumKananVb.SetActive(true);
        injapSabit2Vb.SetActive(true);
        venaKavaSuperiorVb.SetActive(true);
        aortaVb.SetActive(true);
        arteriPulmonariVb.SetActive(true);
    }

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //Debug.Log(vb.VirtualButtonName);
        Debug.Log("Button pressed!");

        switch (vb.VirtualButtonName)
        {
            case "injapBikuspid":
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                injapBikuspid.SetActive(true);
                break;
            case "ventrikelKiri":
                injapBikuspid.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                ventrikelKiri.SetActive(true);
                break;
            case "injapSabit":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                injapSabit.SetActive(true);
                break;
            case "atriumKiri":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                atriumKiri.SetActive(true);
                break;
            case "venaPulmonari":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                venaPulmonari.SetActive(true);
                break;
            case "septum":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                septum.SetActive(true);
                break;
            case "ventrikelKanan":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                ventrikelKanan.SetActive(true);
                break;
            case "venaKavaInferior":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                venaKavaInferior.SetActive(true);
                break;
            case "injapTrikuspid":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                injapTrikuspid.SetActive(true);
                break;
            case "atriumKanan":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                atriumKanan.SetActive(true);
                break;
            case "injapSabit2":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                injapSabit2.SetActive(true);
                break;
            case "venaKavaSuperior":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(false);
                venaKavaSuperior.SetActive(true);
                break;
            case "aorta":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                arteriPulmonari.SetActive(false);
                aorta.SetActive(true);
                break;
            case "arteriPulmonari":
                injapBikuspid.SetActive(false);
                ventrikelKiri.SetActive(false);
                injapSabit.SetActive(false);
                atriumKiri.SetActive(false);
                venaPulmonari.SetActive(false);
                septum.SetActive(false);
                ventrikelKanan.SetActive(false);
                venaKavaInferior.SetActive(false);
                injapTrikuspid.SetActive(false);
                atriumKanan.SetActive(false);
                injapSabit2.SetActive(false);
                venaKavaSuperior.SetActive(false);
                aorta.SetActive(false);
                arteriPulmonari.SetActive(true);
                break;
                //   default:
                //       throw new UnityException("Button not supported: " + vb.VirtualButtonName);
                //           break;
        }

    }

    /// Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released!");
    }

}