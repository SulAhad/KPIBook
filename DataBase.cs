using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIBook
{
    public class DataBase
    {
        private int id;
        private float incedents;
        private float nearMiss;
        private float bbswa;
        private float kol_vo_zam;
        private float brakQuality;

        private float kol_zam_teamA;
        private float kol_zam_teamB;
        private float kol_zam_Sulf;
        private float bbs_teamA;
        private float bbs_teamB;
        private float bbs_Sulf;
        private float rpm_zam_teamA;
        private float rpm_zam_teamB;
        private float rpm_zam_Sulf;
        private float rpm_bbs_teamA;
        private float rpm_bbs_teamB;
        private float rpm_bbs_Sulf;

        private float kol_zam_him_sostav_teamA;
        private float kol_zam_him_sostav_teamB;
        private float kol_zam_him_sostav_Sulf;
        private float kol_zam_upakovka_teamA;
        private float kol_zam_upakovka_teamB;
        private float kol_zam_upakovka_Sulf;

        private float kol_pretenziy_teamA;
        private float kol_pretenziy_teamB;
        private float kol_pretenziy_Sulf;

        private float zabrakov_mat_teamA;
        private float zabrakov_mat_teamB;
        private float zabrakov_mat_Sulf;

        private float brak_sms_teamA;
        private float brak_sms_teamB;
        private float brak_sms_Sulf;

        private float brak_plenka_teamA;
        private float brak_plenka_teamB;
        private float brak_plenka_Sulf;

        private float brak_kroy_teamA;
        private float brak_kroy_teamB;
        private float brak_kroy_Sulf;

        private float params_limits;

        private float compositsia;
        private float compaund;
        private float postdobavki;
        private float fasovka;
        private float slivnaya;
        private float uch_sirya;

        private float udeln_potr_gaza_teamA;
        private float udeln_potr_gaza_teamB;
        private float udeln_potr_gaza_total;

        private float udeln_potr_gaza_gotoviy_prod;

        private float aktiv_voda_emkost1;
        private float aktiv_voda_emkost2;
        private float aktiv_voda_emkost3;
        private float stroka1;
        private float stroka2;
        private float stroka3;
        private float ispolz_vodi_str1;
        private float ispolz_vodi_str2;
        private float ispolz_vodi_str3;

        private float skorost_vigruski_sulfata_teamA;
        private float skorost_vigruski_sulfata_teamB;
        private float skorost_vigruski_sulfata_Sulf;
        private float skorost_vigruski_sulfata_total;

        private float rpm_plan;
        private float rpm_fact;

        private float production_plan_total_plan;
        private float production_plan_total_fact;

        private float production_plan_plan_teamA;
        private float production_plan_plan_teamB;
        private float production_plan_plan_Sulf;
        private float production_plan_otklonenie;

        private float production_plan_fact_teamA;
        private float production_plan_fact_teamB;
        private float production_plan_fact_Sulf;

        private float oee_teamA;
        private float oee_inn1_teamA;
        private float oee_inn2_teamA;
        private float oee_inn3_teamA;
        private float oee_uva4_teamA;
        private float oee_uva5_teamA;
        private float oee_acma_teamA;


        private float oee_teamB;
        private float oee_inn1_teamB;
        private float oee_inn2_teamB;
        private float oee_inn3_teamB;
        private float oee_uva4_teamB;
        private float oee_uva5_teamB;
        private float oee_acma_teamB;

        private float oee_total;

        private float personal_plan_teamA;
        private float personal_fact_teamA;
        private float personal_plan_teamB;
        private float personal_fact_teamB;
        private float personal_plan_Sulf;
        private float personal_fact_Sulf;
        private float personal_total;

        private float personal_shtat_teamA;
        private float personal_lizing_teamA;
        private float otpusk_teamA;
        private float personal_shtat_teamB;
        private float personal_lizing_teamB;
        private float otpusk_teamB;
        private float personal_shtat_Sulf;
        private float personal_lizing_Sulf;
        private float otpusk_Sulf;

        private float planovie_raboti;

        private float sirye_bilo;
        private float brak_bilo;
        private float pil_bilo;
        private float otsev_bilo;

        private float sirye_prihod;
        private float brak_prihod;
        private float pil_prihod;
        private float otsev_prihod;

        private float sirye_rashod;
        private float brak_rashod;
        private float pil_rashod;
        private float otsev_rashod;

        private float sirye_ostatok;
        private float brak_ostatok;
        private float pil_ostatok;
        private float otsev_ostatok;
        private string date;
        private string machineName;

        public DataBase()
        {
        }

        public DataBase(int id, float incedents, float nearMiss, float bbswa, float kol_vo_zam, float brakQuality, float kol_zam_teamA, float kol_zam_teamB, float kol_zam_Sulf, float bbs_teamA, float bbs_teamB, float bbs_Sulf, float rpm_zam_teamA, float rpm_zam_teamB, float rpm_zam_Sulf, float rpm_bbs_teamA, float rpm_bbs_teamB, float rpm_bbs_Sulf, float kol_zam_him_sostav_teamA, float kol_zam_him_sostav_teamB, float kol_zam_him_sostav_Sulf, float kol_zam_upakovka_teamA, float kol_zam_upakovka_teamB, float kol_zam_upakovka_Sulf, float kol_pretenziy_teamA, float kol_pretenziy_teamB, float kol_pretenziy_Sulf, float zabrakov_mat_teamA, float zabrakov_mat_teamB, float zabrakov_mat_Sulf, float brak_sms_teamA, float brak_sms_teamB, float brak_sms_Sulf, float brak_plenka_teamA, float brak_plenka_teamB, float brak_plenka_Sulf, float brak_kroy_teamA, float brak_kroy_teamB, float brak_kroy_Sulf, float params_limits, float compositsia, float compaund, float postdobavki, float fasovka, float slivnaya, float uch_sirya, float udeln_potr_gaza_teamA, float udeln_potr_gaza_teamB, float udeln_potr_gaza_total, float udeln_potr_gaza_gotoviy_prod, float aktiv_voda_emkost1, float aktiv_voda_emkost2, float aktiv_voda_emkost3, float stroka1, float stroka2, float stroka3, float ispolz_vodi_str1, float ispolz_vodi_str2, float ispolz_vodi_str3, float skorost_vigruski_sulfata_teamA, float skorost_vigruski_sulfata_teamB, float skorost_vigruski_sulfata_Sulf, float skorost_vigruski_sulfata_total, float rpm_plan, float rpm_fact, float production_plan_total_plan, float production_plan_total_fact, float production_plan_plan_teamA, float production_plan_plan_teamB, float production_plan_plan_Sulf, float production_plan_otklonenie, float production_plan_fact_teamA, float production_plan_fact_teamB, float production_plan_fact_Sulf, float oee_teamA, float oee_inn1_teamA, float oee_inn2_teamA, float oee_inn3_teamA, float oee_uva4_teamA, float oee_uva5_teamA, float oee_acma_teamA, float oee_teamB, float oee_inn1_teamB, float oee_inn2_teamB, float oee_inn3_teamB, float oee_uva4_teamB, float oee_uva5_teamB, float oee_acma_teamB, float oee_total, float personal_plan_teamA, float personal_fact_teamA, float personal_plan_teamB, float personal_fact_teamB, float personal_plan_Sulf, float personal_fact_Sulf, float personal_total, float personal_shtat_teamA, float personal_lizing_teamA, float otpusk_teamA, float personal_shtat_teamB, float personal_lizing_teamB, float otpusk_teamB, float personal_shtat_Sulf, float personal_lizing_Sulf, float otpusk_Sulf, float planovie_raboti, float sirye_bilo, float brak_bilo, float pil_bilo, float otsev_bilo, float sirye_prihod, float brak_prihod, float pil_prihod, float otsev_prihod, float sirye_rashod, float brak_rashod, float pil_rashod, float otsev_rashod, float sirye_ostatok, float brak_ostatok, float pil_ostatok, float otsev_ostatok, string date, string machineName)
        {
            this.id = id;
            this.incedents = incedents;
            this.nearMiss = nearMiss;
            this.bbswa = bbswa;
            this.kol_vo_zam = kol_vo_zam;
            this.brakQuality = brakQuality;
            this.kol_zam_teamA = kol_zam_teamA;
            this.kol_zam_teamB = kol_zam_teamB;
            this.kol_zam_Sulf = kol_zam_Sulf;
            this.bbs_teamA = bbs_teamA;
            this.bbs_teamB = bbs_teamB;
            this.bbs_Sulf = bbs_Sulf;
            this.rpm_zam_teamA = rpm_zam_teamA;
            this.rpm_zam_teamB = rpm_zam_teamB;
            this.rpm_zam_Sulf = rpm_zam_Sulf;
            this.rpm_bbs_teamA = rpm_bbs_teamA;
            this.rpm_bbs_teamB = rpm_bbs_teamB;
            this.rpm_bbs_Sulf = rpm_bbs_Sulf;
            this.kol_zam_him_sostav_teamA = kol_zam_him_sostav_teamA;
            this.kol_zam_him_sostav_teamB = kol_zam_him_sostav_teamB;
            this.kol_zam_him_sostav_Sulf = kol_zam_him_sostav_Sulf;
            this.kol_zam_upakovka_teamA = kol_zam_upakovka_teamA;
            this.kol_zam_upakovka_teamB = kol_zam_upakovka_teamB;
            this.kol_zam_upakovka_Sulf = kol_zam_upakovka_Sulf;
            this.kol_pretenziy_teamA = kol_pretenziy_teamA;
            this.kol_pretenziy_teamB = kol_pretenziy_teamB;
            this.kol_pretenziy_Sulf = kol_pretenziy_Sulf;
            this.zabrakov_mat_teamA = zabrakov_mat_teamA;
            this.zabrakov_mat_teamB = zabrakov_mat_teamB;
            this.zabrakov_mat_Sulf = zabrakov_mat_Sulf;
            this.brak_sms_teamA = brak_sms_teamA;
            this.brak_sms_teamB = brak_sms_teamB;
            this.brak_sms_Sulf = brak_sms_Sulf;
            this.brak_plenka_teamA = brak_plenka_teamA;
            this.brak_plenka_teamB = brak_plenka_teamB;
            this.brak_plenka_Sulf = brak_plenka_Sulf;
            this.brak_kroy_teamA = brak_kroy_teamA;
            this.brak_kroy_teamB = brak_kroy_teamB;
            this.brak_kroy_Sulf = brak_kroy_Sulf;
            this.params_limits = params_limits;
            this.compositsia = compositsia;
            this.compaund = compaund;
            this.postdobavki = postdobavki;
            this.fasovka = fasovka;
            this.slivnaya = slivnaya;
            this.uch_sirya = uch_sirya;
            this.udeln_potr_gaza_teamA = udeln_potr_gaza_teamA;
            this.udeln_potr_gaza_teamB = udeln_potr_gaza_teamB;
            this.udeln_potr_gaza_total = udeln_potr_gaza_total;
            this.udeln_potr_gaza_gotoviy_prod = udeln_potr_gaza_gotoviy_prod;
            this.aktiv_voda_emkost1 = aktiv_voda_emkost1;
            this.aktiv_voda_emkost2 = aktiv_voda_emkost2;
            this.aktiv_voda_emkost3 = aktiv_voda_emkost3;
            this.stroka1 = stroka1;
            this.stroka2 = stroka2;
            this.stroka3 = stroka3;
            this.ispolz_vodi_str1 = ispolz_vodi_str1;
            this.ispolz_vodi_str2 = ispolz_vodi_str2;
            this.ispolz_vodi_str3 = ispolz_vodi_str3;
            this.skorost_vigruski_sulfata_teamA = skorost_vigruski_sulfata_teamA;
            this.skorost_vigruski_sulfata_teamB = skorost_vigruski_sulfata_teamB;
            this.skorost_vigruski_sulfata_Sulf = skorost_vigruski_sulfata_Sulf;
            this.skorost_vigruski_sulfata_total = skorost_vigruski_sulfata_total;
            this.rpm_plan = rpm_plan;
            this.rpm_fact = rpm_fact;
            this.production_plan_total_plan = production_plan_total_plan;
            this.production_plan_total_fact = production_plan_total_fact;
            this.production_plan_plan_teamA = production_plan_plan_teamA;
            this.production_plan_plan_teamB = production_plan_plan_teamB;
            this.production_plan_plan_Sulf = production_plan_plan_Sulf;
            this.production_plan_otklonenie = production_plan_otklonenie;
            this.production_plan_fact_teamA = production_plan_fact_teamA;
            this.production_plan_fact_teamB = production_plan_fact_teamB;
            this.production_plan_fact_Sulf = production_plan_fact_Sulf;
            this.oee_teamA = oee_teamA;
            this.oee_inn1_teamA = oee_inn1_teamA;
            this.oee_inn2_teamA = oee_inn2_teamA;
            this.oee_inn3_teamA = oee_inn3_teamA;
            this.oee_uva4_teamA = oee_uva4_teamA;
            this.oee_uva5_teamA = oee_uva5_teamA;
            this.oee_acma_teamA = oee_acma_teamA;
            this.oee_teamB = oee_teamB;
            this.oee_inn1_teamB = oee_inn1_teamB;
            this.oee_inn2_teamB = oee_inn2_teamB;
            this.oee_inn3_teamB = oee_inn3_teamB;
            this.oee_uva4_teamB = oee_uva4_teamB;
            this.oee_uva5_teamB = oee_uva5_teamB;
            this.oee_acma_teamB = oee_acma_teamB;
            this.oee_total = oee_total;
            this.personal_plan_teamA = personal_plan_teamA;
            this.personal_fact_teamA = personal_fact_teamA;
            this.personal_plan_teamB = personal_plan_teamB;
            this.personal_fact_teamB = personal_fact_teamB;
            this.personal_plan_Sulf = personal_plan_Sulf;
            this.personal_fact_Sulf = personal_fact_Sulf;
            this.personal_total = personal_total;
            this.personal_shtat_teamA = personal_shtat_teamA;
            this.personal_lizing_teamA = personal_lizing_teamA;
            this.otpusk_teamA = otpusk_teamA;
            this.personal_shtat_teamB = personal_shtat_teamB;
            this.personal_lizing_teamB = personal_lizing_teamB;
            this.otpusk_teamB = otpusk_teamB;
            this.personal_shtat_Sulf = personal_shtat_Sulf;
            this.personal_lizing_Sulf = personal_lizing_Sulf;
            this.otpusk_Sulf = otpusk_Sulf;
            this.planovie_raboti = planovie_raboti;
            this.sirye_bilo = sirye_bilo;
            this.brak_bilo = brak_bilo;
            this.pil_bilo = pil_bilo;
            this.otsev_bilo = otsev_bilo;
            this.sirye_prihod = sirye_prihod;
            this.brak_prihod = brak_prihod;
            this.pil_prihod = pil_prihod;
            this.otsev_prihod = otsev_prihod;
            this.sirye_rashod = sirye_rashod;
            this.brak_rashod = brak_rashod;
            this.pil_rashod = pil_rashod;
            this.otsev_rashod = otsev_rashod;
            this.sirye_ostatok = sirye_ostatok;
            this.brak_ostatok = brak_ostatok;
            this.pil_ostatok = pil_ostatok;
            this.otsev_ostatok = otsev_ostatok;
            this.date = date;
            this.machineName = machineName;
        }

        public int Id { get => id; set => id = value; }
        public float Incedents { get => incedents; set => incedents = value; }
        public float NearMiss { get => nearMiss; set => nearMiss = value; }
        public float Bbswa { get => bbswa; set => bbswa = value; }
        public float Kol_vo_zam { get => kol_vo_zam; set => kol_vo_zam = value; }
        public float BrakQuality { get => brakQuality; set => brakQuality = value; }
        public float Kol_zam_teamA { get => kol_zam_teamA; set => kol_zam_teamA = value; }
        public float Kol_zam_teamB { get => kol_zam_teamB; set => kol_zam_teamB = value; }
        public float Kol_zam_Sulf { get => kol_zam_Sulf; set => kol_zam_Sulf = value; }
        public float Bbs_teamA { get => bbs_teamA; set => bbs_teamA = value; }
        public float Bbs_teamB { get => bbs_teamB; set => bbs_teamB = value; }
        public float Bbs_Sulf { get => bbs_Sulf; set => bbs_Sulf = value; }
        public float Rpm_zam_teamA { get => rpm_zam_teamA; set => rpm_zam_teamA = value; }
        public float Rpm_zam_teamB { get => rpm_zam_teamB; set => rpm_zam_teamB = value; }
        public float Rpm_zam_Sulf { get => rpm_zam_Sulf; set => rpm_zam_Sulf = value; }
        public float Rpm_bbs_teamA { get => rpm_bbs_teamA; set => rpm_bbs_teamA = value; }
        public float Rpm_bbs_teamB { get => rpm_bbs_teamB; set => rpm_bbs_teamB = value; }
        public float Rpm_bbs_Sulf { get => rpm_bbs_Sulf; set => rpm_bbs_Sulf = value; }
        public float Kol_zam_him_sostav_teamA { get => kol_zam_him_sostav_teamA; set => kol_zam_him_sostav_teamA = value; }
        public float Kol_zam_him_sostav_teamB { get => kol_zam_him_sostav_teamB; set => kol_zam_him_sostav_teamB = value; }
        public float Kol_zam_him_sostav_Sulf { get => kol_zam_him_sostav_Sulf; set => kol_zam_him_sostav_Sulf = value; }
        public float Kol_zam_upakovka_teamA { get => kol_zam_upakovka_teamA; set => kol_zam_upakovka_teamA = value; }
        public float Kol_zam_upakovka_teamB { get => kol_zam_upakovka_teamB; set => kol_zam_upakovka_teamB = value; }
        public float Kol_zam_upakovka_Sulf { get => kol_zam_upakovka_Sulf; set => kol_zam_upakovka_Sulf = value; }
        public float Kol_pretenziy_teamA { get => kol_pretenziy_teamA; set => kol_pretenziy_teamA = value; }
        public float Kol_pretenziy_teamB { get => kol_pretenziy_teamB; set => kol_pretenziy_teamB = value; }
        public float Kol_pretenziy_Sulf { get => kol_pretenziy_Sulf; set => kol_pretenziy_Sulf = value; }
        public float Zabrakov_mat_teamA { get => zabrakov_mat_teamA; set => zabrakov_mat_teamA = value; }
        public float Zabrakov_mat_teamB { get => zabrakov_mat_teamB; set => zabrakov_mat_teamB = value; }
        public float Zabrakov_mat_Sulf { get => zabrakov_mat_Sulf; set => zabrakov_mat_Sulf = value; }
        public float Brak_sms_teamA { get => brak_sms_teamA; set => brak_sms_teamA = value; }
        public float Brak_sms_teamB { get => brak_sms_teamB; set => brak_sms_teamB = value; }
        public float Brak_sms_Sulf { get => brak_sms_Sulf; set => brak_sms_Sulf = value; }
        public float Brak_plenka_teamA { get => brak_plenka_teamA; set => brak_plenka_teamA = value; }
        public float Brak_plenka_teamB { get => brak_plenka_teamB; set => brak_plenka_teamB = value; }
        public float Brak_plenka_Sulf { get => brak_plenka_Sulf; set => brak_plenka_Sulf = value; }
        public float Brak_kroy_teamA { get => brak_kroy_teamA; set => brak_kroy_teamA = value; }
        public float Brak_kroy_teamB { get => brak_kroy_teamB; set => brak_kroy_teamB = value; }
        public float Brak_kroy_Sulf { get => brak_kroy_Sulf; set => brak_kroy_Sulf = value; }
        public float Params_limits { get => params_limits; set => params_limits = value; }
        public float Compositsia { get => compositsia; set => compositsia = value; }
        public float Compaund { get => compaund; set => compaund = value; }
        public float Postdobavki { get => postdobavki; set => postdobavki = value; }
        public float Fasovka { get => fasovka; set => fasovka = value; }
        public float Slivnaya { get => slivnaya; set => slivnaya = value; }
        public float Uch_sirya { get => uch_sirya; set => uch_sirya = value; }
        public float Udeln_potr_gaza_teamA { get => udeln_potr_gaza_teamA; set => udeln_potr_gaza_teamA = value; }
        public float Udeln_potr_gaza_teamB { get => udeln_potr_gaza_teamB; set => udeln_potr_gaza_teamB = value; }
        public float Udeln_potr_gaza_total { get => udeln_potr_gaza_total; set => udeln_potr_gaza_total = value; }
        public float Udeln_potr_gaza_gotoviy_prod { get => udeln_potr_gaza_gotoviy_prod; set => udeln_potr_gaza_gotoviy_prod = value; }
        public float Aktiv_voda_emkost1 { get => aktiv_voda_emkost1; set => aktiv_voda_emkost1 = value; }
        public float Aktiv_voda_emkost2 { get => aktiv_voda_emkost2; set => aktiv_voda_emkost2 = value; }
        public float Aktiv_voda_emkost3 { get => aktiv_voda_emkost3; set => aktiv_voda_emkost3 = value; }
        public float Stroka1 { get => stroka1; set => stroka1 = value; }
        public float Stroka2 { get => stroka2; set => stroka2 = value; }
        public float Stroka3 { get => stroka3; set => stroka3 = value; }
        public float Ispolz_vodi_str1 { get => ispolz_vodi_str1; set => ispolz_vodi_str1 = value; }
        public float Ispolz_vodi_str2 { get => ispolz_vodi_str2; set => ispolz_vodi_str2 = value; }
        public float Ispolz_vodi_str3 { get => ispolz_vodi_str3; set => ispolz_vodi_str3 = value; }
        public float Skorost_vigruski_sulfata_teamA { get => skorost_vigruski_sulfata_teamA; set => skorost_vigruski_sulfata_teamA = value; }
        public float Skorost_vigruski_sulfata_teamB { get => skorost_vigruski_sulfata_teamB; set => skorost_vigruski_sulfata_teamB = value; }
        public float Skorost_vigruski_sulfata_Sulf { get => skorost_vigruski_sulfata_Sulf; set => skorost_vigruski_sulfata_Sulf = value; }
        public float Skorost_vigruski_sulfata_total { get => skorost_vigruski_sulfata_total; set => skorost_vigruski_sulfata_total = value; }
        public float Rpm_plan { get => rpm_plan; set => rpm_plan = value; }
        public float Rpm_fact { get => rpm_fact; set => rpm_fact = value; }
        public float Production_plan_total_plan { get => production_plan_total_plan; set => production_plan_total_plan = value; }
        public float Production_plan_total_fact { get => production_plan_total_fact; set => production_plan_total_fact = value; }
        public float Production_plan_plan_teamA { get => production_plan_plan_teamA; set => production_plan_plan_teamA = value; }
        public float Production_plan_plan_teamB { get => production_plan_plan_teamB; set => production_plan_plan_teamB = value; }
        public float Production_plan_plan_Sulf { get => production_plan_plan_Sulf; set => production_plan_plan_Sulf = value; }
        public float Production_plan_otklonenie { get => production_plan_otklonenie; set => production_plan_otklonenie = value; }
        public float Production_plan_fact_teamA { get => production_plan_fact_teamA; set => production_plan_fact_teamA = value; }
        public float Production_plan_fact_teamB { get => production_plan_fact_teamB; set => production_plan_fact_teamB = value; }
        public float Production_plan_fact_Sulf { get => production_plan_fact_Sulf; set => production_plan_fact_Sulf = value; }
        public float Oee_teamA { get => oee_teamA; set => oee_teamA = value; }
        public float Oee_inn1_teamA { get => oee_inn1_teamA; set => oee_inn1_teamA = value; }
        public float Oee_inn2_teamA { get => oee_inn2_teamA; set => oee_inn2_teamA = value; }
        public float Oee_inn3_teamA { get => oee_inn3_teamA; set => oee_inn3_teamA = value; }
        public float Oee_uva4_teamA { get => oee_uva4_teamA; set => oee_uva4_teamA = value; }
        public float Oee_uva5_teamA { get => oee_uva5_teamA; set => oee_uva5_teamA = value; }
        public float Oee_acma_teamA { get => oee_acma_teamA; set => oee_acma_teamA = value; }
        public float Oee_teamB { get => oee_teamB; set => oee_teamB = value; }
        public float Oee_inn1_teamB { get => oee_inn1_teamB; set => oee_inn1_teamB = value; }
        public float Oee_inn2_teamB { get => oee_inn2_teamB; set => oee_inn2_teamB = value; }
        public float Oee_inn3_teamB { get => oee_inn3_teamB; set => oee_inn3_teamB = value; }
        public float Oee_uva4_teamB { get => oee_uva4_teamB; set => oee_uva4_teamB = value; }
        public float Oee_uva5_teamB { get => oee_uva5_teamB; set => oee_uva5_teamB = value; }
        public float Oee_acma_teamB { get => oee_acma_teamB; set => oee_acma_teamB = value; }
        public float Oee_total { get => oee_total; set => oee_total = value; }
        public float Personal_plan_teamA { get => personal_plan_teamA; set => personal_plan_teamA = value; }
        public float Personal_fact_teamA { get => personal_fact_teamA; set => personal_fact_teamA = value; }
        public float Personal_plan_teamB { get => personal_plan_teamB; set => personal_plan_teamB = value; }
        public float Personal_fact_teamB { get => personal_fact_teamB; set => personal_fact_teamB = value; }
        public float Personal_plan_Sulf { get => personal_plan_Sulf; set => personal_plan_Sulf = value; }
        public float Personal_fact_Sulf { get => personal_fact_Sulf; set => personal_fact_Sulf = value; }
        public float Personal_total { get => personal_total; set => personal_total = value; }
        public float Personal_shtat_teamA { get => personal_shtat_teamA; set => personal_shtat_teamA = value; }
        public float Personal_lizing_teamA { get => personal_lizing_teamA; set => personal_lizing_teamA = value; }
        public float Otpusk_teamA { get => otpusk_teamA; set => otpusk_teamA = value; }
        public float Personal_shtat_teamB { get => personal_shtat_teamB; set => personal_shtat_teamB = value; }
        public float Personal_lizing_teamB { get => personal_lizing_teamB; set => personal_lizing_teamB = value; }
        public float Otpusk_teamB { get => otpusk_teamB; set => otpusk_teamB = value; }
        public float Personal_shtat_Sulf { get => personal_shtat_Sulf; set => personal_shtat_Sulf = value; }
        public float Personal_lizing_Sulf { get => personal_lizing_Sulf; set => personal_lizing_Sulf = value; }
        public float Otpusk_Sulf { get => otpusk_Sulf; set => otpusk_Sulf = value; }
        public float Planovie_raboti { get => planovie_raboti; set => planovie_raboti = value; }
        public float Sirye_bilo { get => sirye_bilo; set => sirye_bilo = value; }
        public float Brak_bilo { get => brak_bilo; set => brak_bilo = value; }
        public float Pil_bilo { get => pil_bilo; set => pil_bilo = value; }
        public float Otsev_bilo { get => otsev_bilo; set => otsev_bilo = value; }
        public float Sirye_prihod { get => sirye_prihod; set => sirye_prihod = value; }
        public float Brak_prihod { get => brak_prihod; set => brak_prihod = value; }
        public float Pil_prihod { get => pil_prihod; set => pil_prihod = value; }
        public float Otsev_prihod { get => otsev_prihod; set => otsev_prihod = value; }
        public float Sirye_rashod { get => sirye_rashod; set => sirye_rashod = value; }
        public float Brak_rashod { get => brak_rashod; set => brak_rashod = value; }
        public float Pil_rashod { get => pil_rashod; set => pil_rashod = value; }
        public float Otsev_rashod { get => otsev_rashod; set => otsev_rashod = value; }
        public float Sirye_ostatok { get => sirye_ostatok; set => sirye_ostatok = value; }
        public float Brak_ostatok { get => brak_ostatok; set => brak_ostatok = value; }
        public float Pil_ostatok { get => pil_ostatok; set => pil_ostatok = value; }
        public float Otsev_ostatok { get => otsev_ostatok; set => otsev_ostatok = value; }
        public string Date { get => date; set => date = value; }
        public string MachineName { get => machineName; set => machineName = value; }

    }
}
