using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace KPIBook
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                grid.IsEnabled = false;
            }
        }
        private void SideMenuGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            SideMenuGrid.BeginAnimation(Grid.OpacityProperty, animation);
        }

        private void SideMenuGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            SideMenuGrid.BeginAnimation(Grid.OpacityProperty, animation);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calendarPopup.IsOpen = true;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int value = int.Parse(incedents.Text);
            if (value > 0)
            {
                incedents.Background = Brushes.LightCoral;
            }
            else if (value == 0)
            {
                incedents.Background = Brushes.LightGreen;
            }
        }
        public void Color()
        {
            if (Convert.ToInt64(rpm_zam_teamA.Text) > 0)
            {
                rpm_zam_teamA.Background = Brushes.LightCoral;
            }
            else
            {
                rpm_zam_teamB.Background = Brushes.LightGreen;
            }
            if (Convert.ToInt64(rpm_zam_teamA.Text) > 0)
            {
                rpm_zam_teamB.Background = Brushes.LightCoral;
            }
            else
            {
                rpm_zam_teamB.Background = Brushes.LightGreen;
            }
            if (Convert.ToInt64(rpm_zam_Sulf.Text) > 0)
            {
                rpm_zam_Sulf.Background = Brushes.LightCoral;
            }
            else
            {
                rpm_zam_Sulf.Background = Brushes.LightGreen;
            }
        }
        public void Update()
        {
            try
            {
                downTray.Content = "Обновление....";
                grid.IsEnabled = false;

                DataBaseContext dataBaseContext = new();
                incedents.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Incedents.ToString();
                nearMiss.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.NearMiss.ToString();
                bbswa.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Bbswa.ToString();
                kol_vo_zam.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_vo_zam.ToString();
                brakQuality.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.BrakQuality.ToString();

                kol_zam_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_zam_teamA.ToString();
                kol_zam_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_zam_teamB.ToString();
                kol_zam_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_zam_Sulf.ToString();
                bbs_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Bbs_teamA.ToString();
                bbs_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Bbs_teamB.ToString();
                bbs_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Bbs_Sulf.ToString();
                rpm_zam_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Rpm_zam_teamA.ToString();
                rpm_zam_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Rpm_zam_teamB.ToString();
                rpm_zam_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Rpm_zam_Sulf.ToString();
                rpm_bbs_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Rpm_bbs_teamA.ToString();
                rpm_bbs_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Rpm_bbs_teamB.ToString();
                rpm_bbs_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Rpm_bbs_Sulf.ToString();

                kol_zam_him_sostav_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_zam_him_sostav_teamA.ToString();
                kol_zam_him_sostav_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_zam_him_sostav_teamB.ToString();
                kol_zam_him_sostav_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_zam_him_sostav_Sulf.ToString();
                kol_zam_upakovka_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_zam_upakovka_teamA.ToString();
                kol_zam_upakovka_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_zam_upakovka_teamB.ToString();
                kol_zam_upakovka_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_zam_upakovka_Sulf.ToString();

                kol_pretenziy_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_pretenziy_teamA.ToString();
                kol_pretenziy_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_pretenziy_teamB.ToString();
                kol_pretenziy_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Kol_pretenziy_Sulf.ToString();

                zabrakov_mat_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Zabrakov_mat_teamA.ToString();
                zabrakov_mat_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Zabrakov_mat_teamB.ToString();
                zabrakov_mat_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Zabrakov_mat_Sulf.ToString();

                brak_sms_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_sms_teamA.ToString();
                brak_sms_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_sms_teamB.ToString();
                brak_sms_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_sms_Sulf.ToString();

                brak_plenka_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_plenka_teamA.ToString();
                brak_plenka_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_plenka_teamB.ToString();
                brak_plenka_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_plenka_Sulf.ToString();

                brak_kroy_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_kroy_teamA.ToString();
                brak_kroy_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_kroy_teamB.ToString();
                brak_kroy_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_kroy_Sulf.ToString();

                params_limits.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Params_limits.ToString();

                compositsia.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Compositsia.ToString();
                compaund.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Compaund.ToString();
                postdobavki.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Postdobavki.ToString();
                fasovka.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Fasovka.ToString();
                slivnaya.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Slivnaya.ToString();
                uch_sirya.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Uch_sirya.ToString();

                udeln_potr_gaza_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Udeln_potr_gaza_teamA.ToString();
                udeln_potr_gaza_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Udeln_potr_gaza_teamB.ToString();
                udeln_potr_gaza_total.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Udeln_potr_gaza_total.ToString();

                udeln_potr_gaza_gotoviy_prod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Udeln_potr_gaza_gotoviy_prod.ToString();

                aktiv_voda_emkost1.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Aktiv_voda_emkost1.ToString();
                aktiv_voda_emkost2.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Aktiv_voda_emkost2.ToString();
                aktiv_voda_emkost3.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Aktiv_voda_emkost3.ToString();
                stroka1.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Stroka1.ToString();
                stroka2.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Stroka2.ToString();
                stroka3.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Stroka3.ToString();
                ispolz_vodi_str1.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Ispolz_vodi_str1.ToString();
                ispolz_vodi_str2.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Ispolz_vodi_str2.ToString();
                ispolz_vodi_str3.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Ispolz_vodi_str3.ToString();

                skorost_vigruski_sulfata_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Skorost_vigruski_sulfata_teamA.ToString();
                skorost_vigruski_sulfata_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Skorost_vigruski_sulfata_teamB.ToString();
                skorost_vigruski_sulfata_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Skorost_vigruski_sulfata_Sulf.ToString();
                skorost_vigruski_sulfata_total.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Skorost_vigruski_sulfata_total.ToString();

                rpm_plan.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Rpm_plan.ToString();
                rpm_fact.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Rpm_fact.ToString();

                production_plan_total_plan.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Production_plan_total_plan.ToString();
                production_plan_total_fact.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Production_plan_total_fact.ToString();

                production_plan_plan_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Production_plan_plan_teamA.ToString();
                production_plan_plan_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Production_plan_plan_teamB.ToString();
                production_plan_plan_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Production_plan_plan_Sulf.ToString();
                production_plan_otklonenie.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Production_plan_otklonenie.ToString();

                production_plan_fact_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Production_plan_fact_teamA.ToString();
                production_plan_fact_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Production_plan_fact_teamB.ToString();
                production_plan_fact_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Production_plan_fact_Sulf.ToString();

                oee_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_teamA.ToString();
                oee_inn1_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_inn1_teamA.ToString();
                oee_inn2_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_inn2_teamA.ToString();
                oee_inn3_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_inn3_teamA.ToString();
                oee_uva4_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_uva4_teamA.ToString();
                oee_uva5_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_uva5_teamA.ToString();
                oee_acma_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_acma_teamA.ToString();

                oee_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_teamB.ToString();
                oee_inn1_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_inn1_teamB.ToString();
                oee_inn2_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_inn2_teamB.ToString();
                oee_inn3_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_inn3_teamB.ToString();
                oee_uva4_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_uva4_teamB.ToString();
                oee_uva5_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_uva5_teamB.ToString();
                oee_acma_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_acma_teamB.ToString();

                oee_total.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Oee_total.ToString();

                personal_plan_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_plan_teamA.ToString();
                personal_fact_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_fact_teamA.ToString();
                personal_plan_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_plan_teamB.ToString();
                personal_fact_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_fact_teamB.ToString();
                personal_plan_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_plan_Sulf.ToString();
                personal_fact_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_fact_Sulf.ToString();
                personal_total.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_total.ToString();

                personal_shtat_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_shtat_teamA.ToString();
                personal_lizing_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_lizing_teamA.ToString();
                otpusk_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Otpusk_teamA.ToString();
                personal_shtat_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_shtat_teamB.ToString();
                personal_lizing_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_lizing_teamB.ToString();
                otpusk_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Otpusk_teamB.ToString();
                personal_shtat_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_shtat_Sulf.ToString();
                personal_lizing_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Personal_lizing_Sulf.ToString();
                otpusk_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Otpusk_Sulf.ToString();

                planovie_raboti.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Planovie_raboti.ToString();

                sirye_bilo.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Sirye_bilo.ToString();
                brak_bilo.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_bilo.ToString();
                pil_bilo.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Pil_bilo.ToString();
                otsev_bilo.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Otsev_bilo.ToString();

                sirye_prihod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Sirye_prihod.ToString();
                brak_prihod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_prihod.ToString();
                pil_prihod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Pil_prihod.ToString();
                otsev_prihod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Otsev_prihod.ToString();

                sirye_rashod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Sirye_rashod.ToString();
                brak_rashod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_rashod.ToString();
                pil_rashod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Pil_rashod.ToString();
                otsev_rashod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Otsev_rashod.ToString();

                sirye_ostatok.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Sirye_ostatok.ToString();
                brak_ostatok.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Brak_ostatok.ToString();
                pil_ostatok.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Pil_ostatok.ToString();
                otsev_ostatok.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).FirstOrDefault()?.Otsev_ostatok.ToString();
                downTray.Content = "";
                grid.IsEnabled = true;
            }
            catch (Exception ex)
            {
                downTray.Content = "Не удалось обновить данные" + ex.Message;
                MessageBox.Show("Ошибка: " + ex.Message);
                grid.IsEnabled = false;
            }
        }
        private void NumericAndDotTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]"); // ограничиваем ввод только цифрами и точкой
            TextBox textBox = sender as TextBox;
            string text = textBox.Text.Insert(textBox.SelectionStart, e.Text); // получаем текущий текст с учетом вводимого символа

            if (text.Count(x => x == ',') > 1) // проверяем, что точек не больше одной
            {
                e.Handled = true; // отменяем ввод
                downTray.Content = "Можно ввести только одну точку!"; // выводим сообщение об ошибке
            }
            else
            {
                e.Handled = regex.IsMatch(e.Text); // отменяем ввод, если текст не соответствует регулярному выражению
            }
        }
        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+"); // ограничиваем ввод только цифрами и запятой
            TextBox textBox = sender as TextBox;
            string text = textBox.Text.Insert(textBox.SelectionStart, e.Text); // получаем текущий текст с учетом вводимого символа

            if (text.Count(x => x == ',') > 1) // проверяем, что запятых не больше одной
            {
                e.Handled = true; // отменяем ввод
                MessageBox.Show("Можно ввести только одну запятую!"); // выводим сообщение об ошибке
            }
            else
            {
                e.Handled = regex.IsMatch(e.Text); // отменяем ввод, если текст не соответствует регулярному выражению
            }
        }
        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                downTray.Content = "Поиск....";
                grid.IsEnabled = false;
                string selectedDate = Convert.ToString(calendar1.SelectedDate.Value.ToShortDateString());

                DataBaseContext dataBaseContext = new();
                incedents.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Incedents.ToString();
                nearMiss.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.NearMiss.ToString();
                bbswa.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Bbswa.ToString();
                kol_vo_zam.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_vo_zam.ToString();
                brakQuality.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.BrakQuality.ToString();

                kol_zam_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_zam_teamA.ToString();
                kol_zam_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_zam_teamB.ToString();
                kol_zam_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_zam_Sulf.ToString();
                bbs_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Bbs_teamA.ToString();
                bbs_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Bbs_teamB.ToString();
                bbs_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Bbs_Sulf.ToString();
                rpm_zam_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Rpm_zam_teamA.ToString();
                rpm_zam_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Rpm_zam_teamB.ToString();
                rpm_zam_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Rpm_zam_Sulf.ToString();
                rpm_bbs_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Rpm_bbs_teamA.ToString();
                rpm_bbs_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Rpm_bbs_teamB.ToString();
                rpm_bbs_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Rpm_bbs_Sulf.ToString();

                kol_zam_him_sostav_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_zam_him_sostav_teamA.ToString();
                kol_zam_him_sostav_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_zam_him_sostav_teamB.ToString();
                kol_zam_him_sostav_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_zam_him_sostav_Sulf.ToString();
                kol_zam_upakovka_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_zam_upakovka_teamA.ToString();
                kol_zam_upakovka_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_zam_upakovka_teamB.ToString();
                kol_zam_upakovka_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_zam_upakovka_Sulf.ToString();

                kol_pretenziy_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_pretenziy_teamA.ToString();
                kol_pretenziy_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_pretenziy_teamB.ToString();
                kol_pretenziy_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Kol_pretenziy_Sulf.ToString();

                zabrakov_mat_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Zabrakov_mat_teamA.ToString();
                zabrakov_mat_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Zabrakov_mat_teamB.ToString();
                zabrakov_mat_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Zabrakov_mat_Sulf.ToString();

                brak_sms_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_sms_teamA.ToString();
                brak_sms_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_sms_teamB.ToString();
                brak_sms_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_sms_Sulf.ToString();

                brak_plenka_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_plenka_teamA.ToString();
                brak_plenka_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_plenka_teamB.ToString();
                brak_plenka_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_plenka_Sulf.ToString();

                brak_kroy_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_kroy_teamA.ToString();
                brak_kroy_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_kroy_teamB.ToString();
                brak_kroy_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_kroy_Sulf.ToString();

                params_limits.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Params_limits.ToString();

                compositsia.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Compositsia.ToString();
                compaund.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Compaund.ToString();
                postdobavki.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Postdobavki.ToString();
                fasovka.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Fasovka.ToString();
                slivnaya.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Slivnaya.ToString();
                uch_sirya.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Uch_sirya.ToString();

                udeln_potr_gaza_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Udeln_potr_gaza_teamA.ToString();
                udeln_potr_gaza_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Udeln_potr_gaza_teamB.ToString();
                udeln_potr_gaza_total.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Udeln_potr_gaza_total.ToString();

                udeln_potr_gaza_gotoviy_prod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Udeln_potr_gaza_gotoviy_prod.ToString();

                aktiv_voda_emkost1.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Aktiv_voda_emkost1.ToString();
                aktiv_voda_emkost2.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Aktiv_voda_emkost2.ToString();
                aktiv_voda_emkost3.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Aktiv_voda_emkost3.ToString();
                stroka1.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Stroka1.ToString();
                stroka2.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Stroka2.ToString();
                stroka3.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Stroka3.ToString();
                ispolz_vodi_str1.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Ispolz_vodi_str1.ToString();
                ispolz_vodi_str2.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Ispolz_vodi_str2.ToString();
                ispolz_vodi_str3.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Ispolz_vodi_str3.ToString();

                skorost_vigruski_sulfata_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Skorost_vigruski_sulfata_teamA.ToString();
                skorost_vigruski_sulfata_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Skorost_vigruski_sulfata_teamB.ToString();
                skorost_vigruski_sulfata_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Skorost_vigruski_sulfata_Sulf.ToString();
                skorost_vigruski_sulfata_total.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Skorost_vigruski_sulfata_total.ToString();

                rpm_plan.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Rpm_plan.ToString();
                rpm_fact.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Rpm_fact.ToString();

                production_plan_total_plan.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Production_plan_total_plan.ToString();
                production_plan_total_fact.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Production_plan_total_fact.ToString();

                production_plan_plan_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Production_plan_plan_teamA.ToString();
                production_plan_plan_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Production_plan_plan_teamB.ToString();
                production_plan_plan_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Production_plan_plan_Sulf.ToString();
                production_plan_otklonenie.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Production_plan_otklonenie.ToString();

                production_plan_fact_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Production_plan_fact_teamA.ToString();
                production_plan_fact_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Production_plan_fact_teamB.ToString();
                production_plan_fact_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Production_plan_fact_Sulf.ToString();

                oee_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_teamA.ToString();
                oee_inn1_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_inn1_teamA.ToString();
                oee_inn2_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_inn2_teamA.ToString();
                oee_inn3_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_inn3_teamA.ToString();
                oee_uva4_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_uva4_teamA.ToString();
                oee_uva5_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_uva5_teamA.ToString();
                oee_acma_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_acma_teamA.ToString();

                oee_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_teamB.ToString();
                oee_inn1_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_inn1_teamB.ToString();
                oee_inn2_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_inn2_teamB.ToString();
                oee_inn3_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_inn3_teamB.ToString();
                oee_uva4_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_uva4_teamB.ToString();
                oee_uva5_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_uva5_teamB.ToString();
                oee_acma_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_acma_teamB.ToString();

                oee_total.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Oee_total.ToString();

                personal_plan_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_plan_teamA.ToString();
                personal_fact_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_fact_teamA.ToString();
                personal_plan_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_plan_teamB.ToString();
                personal_fact_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_fact_teamB.ToString();
                personal_plan_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_plan_Sulf.ToString();
                personal_fact_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_fact_Sulf.ToString();
                personal_total.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_total.ToString();

                personal_shtat_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_shtat_teamA.ToString();
                personal_lizing_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_lizing_teamA.ToString();
                otpusk_teamA.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Otpusk_teamA.ToString();
                personal_shtat_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_shtat_teamB.ToString();
                personal_lizing_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_lizing_teamB.ToString();
                otpusk_teamB.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Otpusk_teamB.ToString();
                personal_shtat_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_shtat_Sulf.ToString();
                personal_lizing_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Personal_lizing_Sulf.ToString();
                otpusk_Sulf.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Otpusk_Sulf.ToString();

                planovie_raboti.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Planovie_raboti.ToString();

                sirye_bilo.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Sirye_bilo.ToString();
                brak_bilo.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_bilo.ToString();
                pil_bilo.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Pil_bilo.ToString();
                otsev_bilo.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Otsev_bilo.ToString();

                sirye_prihod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Sirye_prihod.ToString();
                brak_prihod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_prihod.ToString();
                pil_prihod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Pil_prihod.ToString();
                otsev_prihod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Otsev_prihod.ToString();

                sirye_rashod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Sirye_rashod.ToString();
                brak_rashod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_rashod.ToString();
                pil_rashod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Pil_rashod.ToString();
                otsev_rashod.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Otsev_rashod.ToString();

                sirye_ostatok.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Sirye_ostatok.ToString();
                brak_ostatok.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Brak_ostatok.ToString();
                pil_ostatok.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Pil_ostatok.ToString();
                otsev_ostatok.Text = dataBaseContext.DataBases.OrderByDescending(i => i.Id).Where(x => x.Date == selectedDate).FirstOrDefault()?.Otsev_ostatok.ToString();

                downTray.Content = "Выполнено поиск на дату" + selectedDate.ToString();
                grid.IsEnabled = true;
                calendarPopup.IsOpen = false;
            }
            catch (Exception ex)
            {
                downTray.Content = "Ошибка поиска даты..." + ex.Message;
                MessageBox.Show("Ошибка: " + ex.Message);
                grid.IsEnabled = true;
            }
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            try
            {
                downTray.Content = "Сохранение...";
                downTray.Background = Brushes.Yellow;
                grid.IsEnabled = false;
                DataBaseContext db = new();
                DataBase tim = new()
                {
                    Incedents = float.Parse(incedents.Text.Trim()),
                    NearMiss = float.Parse(nearMiss.Text.Trim()),
                    Bbswa = float.Parse(bbswa.Text.Trim()),
                    Kol_vo_zam = float.Parse(kol_vo_zam.Text.Trim()),
                    BrakQuality = float.Parse(brakQuality.Text.Trim()),
                    Kol_zam_teamA = float.Parse(kol_zam_teamA.Text.Trim()),
                    Kol_zam_teamB = float.Parse(kol_zam_teamB.Text.Trim()),
                    Kol_zam_Sulf = float.Parse(kol_zam_Sulf.Text.Trim()),
                    Bbs_teamA = float.Parse(bbs_teamA.Text.Trim()),
                    Bbs_teamB = float.Parse(bbs_teamB.Text.Trim()),
                    Bbs_Sulf = float.Parse(bbs_Sulf.Text.Trim()),
                    Rpm_zam_teamA = float.Parse(rpm_zam_teamA.Text.Trim()),
                    Rpm_zam_teamB = float.Parse(rpm_zam_teamB.Text.Trim()),
                    Rpm_zam_Sulf = float.Parse(rpm_zam_Sulf.Text.Trim()),
                    Rpm_bbs_teamA = float.Parse(rpm_bbs_teamA.Text.Trim()),
                    Rpm_bbs_teamB = float.Parse(rpm_bbs_teamB.Text.Trim()),
                    Rpm_bbs_Sulf = float.Parse(rpm_bbs_Sulf.Text.Trim()),
                    Kol_zam_him_sostav_teamA = float.Parse(kol_zam_him_sostav_teamA.Text.Trim()),
                    Kol_zam_him_sostav_teamB = float.Parse(kol_zam_him_sostav_teamB.Text.Trim()),
                    Kol_zam_him_sostav_Sulf = float.Parse(kol_zam_him_sostav_Sulf.Text.Trim()),
                    Kol_zam_upakovka_teamA = float.Parse(kol_zam_upakovka_teamA.Text.Trim()),
                    Kol_zam_upakovka_teamB = float.Parse(kol_zam_upakovka_teamB.Text.Trim()),
                    Kol_zam_upakovka_Sulf = float.Parse(kol_zam_upakovka_Sulf.Text.Trim()),
                    Kol_pretenziy_teamA = float.Parse(kol_pretenziy_teamA.Text.Trim()),
                    Kol_pretenziy_teamB = float.Parse(kol_pretenziy_teamB.Text.Trim()),
                    Kol_pretenziy_Sulf = float.Parse(kol_pretenziy_Sulf.Text.Trim()),
                    Zabrakov_mat_teamA = float.Parse(zabrakov_mat_teamA.Text.Trim()),
                    Zabrakov_mat_teamB = float.Parse(zabrakov_mat_teamB.Text.Trim()),
                    Zabrakov_mat_Sulf = float.Parse(zabrakov_mat_Sulf.Text.Trim()),
                    Brak_sms_teamA = float.Parse(brak_sms_teamA.Text.Trim()),
                    Brak_sms_teamB = float.Parse(brak_sms_teamB.Text.Trim()),
                    Brak_sms_Sulf = float.Parse(brak_sms_Sulf.Text.Trim()),
                    Brak_plenka_teamA = float.Parse(brak_plenka_teamA.Text.Trim()),
                    Brak_plenka_teamB = float.Parse(brak_plenka_teamB.Text.Trim()),
                    Brak_plenka_Sulf = float.Parse(brak_plenka_Sulf.Text.Trim()),
                    Brak_kroy_teamA = float.Parse(brak_kroy_teamA.Text.Trim()),
                    Brak_kroy_teamB = float.Parse(brak_kroy_teamB.Text.Trim()),
                    Brak_kroy_Sulf = float.Parse(brak_kroy_Sulf.Text.Trim()),
                    Params_limits = float.Parse(params_limits.Text.Trim()),
                    Compositsia = float.Parse(compositsia.Text.Trim()),
                    Compaund = float.Parse(compaund.Text.Trim()),
                    Postdobavki = float.Parse(postdobavki.Text.Trim()),
                    Fasovka = float.Parse(fasovka.Text.Trim()),
                    Slivnaya = float.Parse(slivnaya.Text.Trim()),
                    Uch_sirya = float.Parse(uch_sirya.Text.Trim()),
                    Udeln_potr_gaza_teamA = float.Parse(udeln_potr_gaza_teamA.Text.Trim()),
                    Udeln_potr_gaza_teamB = float.Parse(udeln_potr_gaza_teamB.Text.Trim()),
                    Udeln_potr_gaza_total = float.Parse(udeln_potr_gaza_total.Text.Trim()),
                    Udeln_potr_gaza_gotoviy_prod = float.Parse(udeln_potr_gaza_gotoviy_prod.Text.Trim()),
                    Aktiv_voda_emkost1 = float.Parse(aktiv_voda_emkost1.Text.Trim()),
                    Aktiv_voda_emkost2 = float.Parse(aktiv_voda_emkost2.Text.Trim()),
                    Aktiv_voda_emkost3 = float.Parse(aktiv_voda_emkost3.Text.Trim()),
                    Stroka1 = float.Parse(stroka1.Text.Trim()),
                    Stroka2 = float.Parse(stroka2.Text.Trim()),
                    Stroka3 = float.Parse(stroka3.Text.Trim()),
                    Ispolz_vodi_str1 = float.Parse(ispolz_vodi_str1.Text.Trim()),
                    Ispolz_vodi_str2 = float.Parse(ispolz_vodi_str2.Text.Trim()),
                    Ispolz_vodi_str3 = float.Parse(ispolz_vodi_str3.Text.Trim()),
                    Skorost_vigruski_sulfata_teamA = float.Parse(skorost_vigruski_sulfata_teamA.Text.Trim()),
                    Skorost_vigruski_sulfata_teamB = float.Parse(skorost_vigruski_sulfata_teamB.Text.Trim()),
                    Skorost_vigruski_sulfata_Sulf = float.Parse(skorost_vigruski_sulfata_Sulf.Text.Trim()),
                    Skorost_vigruski_sulfata_total = float.Parse(skorost_vigruski_sulfata_total.Text.Trim()),
                    Rpm_plan = float.Parse(rpm_plan.Text.Trim()),
                    Rpm_fact = float.Parse(rpm_fact.Text.Trim()),
                    Production_plan_total_plan = float.Parse(production_plan_total_plan.Text.Trim()),
                    Production_plan_total_fact = float.Parse(production_plan_total_fact.Text.Trim()),
                    Production_plan_plan_teamA = float.Parse(production_plan_plan_teamA.Text.Trim()),
                    Production_plan_plan_teamB = float.Parse(production_plan_plan_teamB.Text.Trim()),
                    Production_plan_plan_Sulf = float.Parse(production_plan_plan_Sulf.Text.Trim()),
                    Production_plan_otklonenie = float.Parse(production_plan_otklonenie.Text.Trim()),
                    Production_plan_fact_teamA = float.Parse(production_plan_fact_teamA.Text.Trim()),
                    Production_plan_fact_teamB = float.Parse(production_plan_fact_teamB.Text.Trim()),
                    Production_plan_fact_Sulf = float.Parse(production_plan_fact_Sulf.Text.Trim()),
                    Oee_teamA = float.Parse(oee_teamA.Text.Trim()),
                    Oee_inn1_teamA = float.Parse(oee_inn1_teamA.Text.Trim()),
                    Oee_inn2_teamA = float.Parse(oee_inn2_teamA.Text.Trim()),
                    Oee_inn3_teamA = float.Parse(oee_inn3_teamA.Text.Trim()),
                    Oee_uva4_teamA = float.Parse(oee_uva4_teamA.Text.Trim()),
                    Oee_uva5_teamA = float.Parse(oee_uva5_teamA.Text.Trim()),
                    Oee_acma_teamA = float.Parse(oee_acma_teamA.Text.Trim()),
                    Oee_teamB = float.Parse(oee_teamB.Text.Trim()),
                    Oee_inn1_teamB = float.Parse(oee_inn1_teamB.Text.Trim()),
                    Oee_inn2_teamB = float.Parse(oee_inn2_teamB.Text.Trim()),
                    Oee_inn3_teamB = float.Parse(oee_inn3_teamB.Text.Trim()),
                    Oee_uva4_teamB = float.Parse(oee_uva4_teamB.Text.Trim()),
                    Oee_uva5_teamB = float.Parse(oee_uva5_teamB.Text.Trim()),
                    Oee_acma_teamB = float.Parse(oee_acma_teamB.Text.Trim()),
                    Oee_total = float.Parse(oee_total.Text.Trim()),
                    Personal_plan_teamA = float.Parse(personal_plan_teamA.Text.Trim()),
                    Personal_fact_teamA = float.Parse(personal_fact_teamA.Text.Trim()),
                    Personal_plan_teamB = float.Parse(personal_plan_teamB.Text.Trim()),
                    Personal_fact_teamB = float.Parse(personal_fact_teamB.Text.Trim()),
                    Personal_plan_Sulf = float.Parse(personal_plan_Sulf.Text.Trim()),
                    Personal_fact_Sulf = float.Parse(personal_fact_Sulf.Text.Trim()),
                    Personal_total = float.Parse(personal_total.Text.Trim()),
                    Personal_shtat_teamA = float.Parse(personal_shtat_teamA.Text.Trim()),
                    Personal_lizing_teamA = float.Parse(personal_lizing_teamA.Text.Trim()),
                    Otpusk_teamA = float.Parse(otpusk_teamA.Text.Trim()),
                    Personal_shtat_teamB = float.Parse(personal_shtat_teamB.Text.Trim()),
                    Personal_lizing_teamB = float.Parse(personal_lizing_teamB.Text.Trim()),
                    Otpusk_teamB = float.Parse(otpusk_teamB.Text.Trim()),
                    Personal_shtat_Sulf = float.Parse(personal_shtat_Sulf.Text.Trim()),
                    Personal_lizing_Sulf = float.Parse(personal_lizing_Sulf.Text.Trim()),
                    Otpusk_Sulf = float.Parse(otpusk_Sulf.Text.Trim()),
                    Planovie_raboti = float.Parse(planovie_raboti.Text.Trim()),
                    Sirye_bilo = float.Parse(sirye_bilo.Text.Trim()),
                    Brak_bilo = float.Parse(brak_bilo.Text.Trim()),
                    Pil_bilo = float.Parse(pil_bilo.Text.Trim()),
                    Otsev_bilo = float.Parse(otsev_bilo.Text.Trim()),
                    Sirye_prihod = float.Parse(sirye_prihod.Text.Trim()),
                    Brak_prihod = float.Parse(brak_prihod.Text.Trim()),
                    Pil_prihod = float.Parse(pil_prihod.Text.Trim()),
                    Otsev_prihod = float.Parse(otsev_prihod.Text.Trim()),
                    Sirye_rashod = float.Parse(sirye_rashod.Text.Trim()),
                    Brak_rashod = float.Parse(brak_rashod.Text.Trim()),
                    Pil_rashod = float.Parse(pil_rashod.Text.Trim()),
                    Otsev_rashod = float.Parse(otsev_rashod.Text.Trim()),
                    Sirye_ostatok = float.Parse(sirye_ostatok.Text.Trim()),
                    Brak_ostatok = float.Parse(brak_ostatok.Text.Trim()),
                    Pil_ostatok = float.Parse(pil_ostatok.Text.Trim()),
                    Otsev_ostatok = float.Parse(otsev_ostatok.Text.Trim()),
                    Date = DateTime.Now.ToString("dd.MM.yyyy"),
                    MachineName = Environment.MachineName.ToString()
                };
                db.DataBases.Add(tim);
                db.SaveChanges();
                Update();
                downTray.Background = Brushes.LightGreen;
                downTray.Content = "Сохранено!";
                grid.IsEnabled = true;
            }
            catch (Exception ex)
            {
                downTray.Content = "Ошибка сохранения..." + ex.Message;
                downTray.Background = Brushes.LightGray;
                MessageBox.Show("Ошибка: " + ex.Message);
                grid.IsEnabled = true;
            }
        }
        private void Incedents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            if (selectedItem != null)
            {
                int selectedValue = int.Parse(selectedItem.Content.ToString());

                if (selectedValue == 0)
                {
                    // Закрашиваем ячейку в красный, если выбрано 0
                    comboBox.Background = Brushes.LightGreen;
                }
                else if (selectedValue > 0)
                {
                    // Закрашиваем ячейку в красный, если выбрано число больше 0
                    comboBox.Background = Brushes.LightCoral;
                }
                else
                {
                    // Восстанавливаем стандартный фон, если не выбрано ни 0, ни число больше 0
                    comboBox.Background = Brushes.LightGreen;
                }
            }
        }
        private void SelectionTextBoxChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string selectedText = textBox.Text;

            if (!string.IsNullOrEmpty(selectedText))
            {
                if (int.TryParse(selectedText, out int selectedValue))
                {
                    if (selectedValue == 0)
                    {
                        // Закрашиваем ячейку в красный, если выбрано 0
                        textBox.Background = Brushes.LightGreen;
                    }
                    else if (selectedValue > 0)
                    {
                        // Закрашиваем ячейку в зеленый, если выбрано число больше 0
                        textBox.Background = Brushes.LightCoral;
                    }
                }
                else
                {
                    // Восстанавливаем стандартный фон, если введено некорректное значение
                    textBox.Background = Brushes.White;
                }
            }
            else
            {
                // Очищаем фон, если не выбрано значение
                textBox.Background = Brushes.White;
            }
        }
        private void Bbswa_Loaded(object sender, RoutedEventArgs e)
        {
            // Установите обработчик события TextChanged для первого TextBox
            bbs_teamA.TextChanged += TextBox1_TextChanged;
            bbs_teamB.TextChanged += TextBox1_TextChanged;
            bbs_Sulf.TextChanged += TextBox1_TextChanged;
            rpm_bbs_teamA.TextChanged += TextBox1_TextChanged;
            rpm_bbs_teamB.TextChanged += TextBox1_TextChanged;
            rpm_bbs_Sulf.TextChanged += TextBox1_TextChanged;
        }
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(bbs_teamA.Text, out int bbs_teamA_value);
            int.TryParse(bbs_teamB.Text, out int bbs_teamB_value);
            int.TryParse(bbs_Sulf.Text, out int bbs_team_Sulf_value);

            int.TryParse(rpm_bbs_teamA.Text, out int rpm_bbs_teamA_value);
            int.TryParse(rpm_bbs_teamB.Text, out int rpm_bbs_teamB_value);
            int.TryParse(rpm_bbs_Sulf.Text, out int rpm_bbs_Sulf_value);
            // Выполните суммирование значений
            long sum = (long)bbs_teamA_value + bbs_teamB_value + bbs_team_Sulf_value + rpm_bbs_teamA_value + rpm_bbs_teamB_value + rpm_bbs_Sulf_value;

            // Установите сумму в третий TextBox
            bbswa.Text = sum.ToString();

        }
        private void Kol_vo_zam_Loaded(object sender, RoutedEventArgs e)
        {
            // Установите обработчик события TextChanged для первого TextBox
            kol_zam_teamA.TextChanged += Kol_vo_zam_TextChanged;
            kol_zam_teamB.TextChanged += Kol_vo_zam_TextChanged;
            kol_zam_Sulf.TextChanged += Kol_vo_zam_TextChanged;
            rpm_zam_teamA.TextChanged += Kol_vo_zam_TextChanged;
            rpm_zam_teamB.TextChanged += Kol_vo_zam_TextChanged;
            rpm_zam_Sulf.TextChanged += Kol_vo_zam_TextChanged;
        }
        private void Kol_vo_zam_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(kol_zam_teamA.Text, out int kol_zam_teamA_value);
            int.TryParse(kol_zam_teamB.Text, out int kol_zam_teamB_value);
            int.TryParse(kol_zam_Sulf.Text, out int kol_zam_Sulf_value);

            int.TryParse(rpm_zam_teamA.Text, out int rpm_zam_teamA_value);
            int.TryParse(rpm_zam_teamB.Text, out int rpm_zam_teamB_value);
            int.TryParse(rpm_zam_Sulf.Text, out int rpm_zam_Sulf_value);
            // Выполните суммирование значений
            long sum = (long)kol_zam_teamA_value + kol_zam_teamB_value + kol_zam_Sulf_value + rpm_zam_teamA_value + rpm_zam_teamB_value + rpm_zam_Sulf_value;

            // Установите сумму в третий TextBox
            kol_vo_zam.Text = sum.ToString();

        }
        private void BrakQuality_Loaded(object sender, RoutedEventArgs e)
        {
            brak_sms_teamA.TextChanged += BrakQuality_TextChanged;
            brak_sms_teamB.TextChanged += BrakQuality_TextChanged;
            brak_sms_Sulf.TextChanged += BrakQuality_TextChanged;
        }
        private void BrakQuality_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(brak_sms_teamA.Text, out int brak_sms_teamA_value);
            int.TryParse(brak_sms_teamB.Text, out int brak_sms_teamB_value);
            int.TryParse(brak_sms_Sulf.Text, out int brak_sms_Sulf_value);
            long sum = (long)brak_sms_teamA_value + brak_sms_teamB_value + brak_sms_Sulf_value;
            brakQuality.Text = sum.ToString();
        }
        private void Params_limits_Loaded(object sender, RoutedEventArgs e)
        {
            compositsia.TextChanged += Params_limits_TextChanged;
            compaund.TextChanged += Params_limits_TextChanged;
            postdobavki.TextChanged += Params_limits_TextChanged;
            fasovka.TextChanged += Params_limits_TextChanged;
            slivnaya.TextChanged += Params_limits_TextChanged;
            uch_sirya.TextChanged += Params_limits_TextChanged;
        }
        private void Params_limits_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (compositsia != null && int.TryParse(compositsia.Text, out int compositsia_value))
                {
                    int.TryParse(compaund.Text, out int compaund_value);
                    int.TryParse(postdobavki.Text, out int postdobavki_value);
                    int.TryParse(fasovka.Text, out int fasovka_value);
                    int.TryParse(slivnaya.Text, out int slivnaya_value);
                    int.TryParse(uch_sirya.Text, out int uch_sirya_value);
                    long sum = (long)compositsia_value + compaund_value + postdobavki_value + fasovka_value + slivnaya_value + uch_sirya_value;
                    params_limits.Text = sum.ToString();
                }
                
                
            }
            catch (Exception ex)
            {
                downTray.Content = ex.Message;
            }
            
        }
        private void Skorost_vigruski_sulfata_total_Loaded(object sender, RoutedEventArgs e)
        {
            skorost_vigruski_sulfata_teamA.TextChanged += Skorost_vigruski_sulfata_TextChanged;
            skorost_vigruski_sulfata_teamB.TextChanged += Skorost_vigruski_sulfata_TextChanged;
            skorost_vigruski_sulfata_Sulf.TextChanged += Skorost_vigruski_sulfata_TextChanged;
        }
        private void Skorost_vigruski_sulfata_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(skorost_vigruski_sulfata_teamA.Text, out int skorost_vigruski_sulfata_teamA_value);
            int.TryParse(skorost_vigruski_sulfata_teamB.Text, out int skorost_vigruski_sulfata_teamB_value);
            int.TryParse(skorost_vigruski_sulfata_Sulf.Text, out int skorost_vigruski_sulfata_Sulf_value);
            long sum = (long)skorost_vigruski_sulfata_teamA_value + skorost_vigruski_sulfata_teamB_value + skorost_vigruski_sulfata_Sulf_value;
            skorost_vigruski_sulfata_total.Text = sum.ToString();
        }
        private void Production_plan_total_plan_Loaded(object sender, RoutedEventArgs e)
        {
            production_plan_plan_teamA.TextChanged += Production_plan_total_plan_TextChanged;
            production_plan_plan_teamB.TextChanged += Production_plan_total_plan_TextChanged;
            production_plan_plan_Sulf.TextChanged += Production_plan_total_plan_TextChanged;
        }
        private void Production_plan_total_plan_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(production_plan_plan_teamA.Text, out int production_plan_plan_teamA_value);
            int.TryParse(production_plan_plan_teamB.Text, out int production_plan_plan_teamB_value);
            int.TryParse(production_plan_plan_Sulf.Text, out int production_plan_plan_Sulf_value);
            long sum = (long)production_plan_plan_teamA_value + production_plan_plan_teamB_value + production_plan_plan_Sulf_value;
            production_plan_total_plan.Text = sum.ToString();
        }
        private void Production_plan_total_fact_Loaded(object sender, RoutedEventArgs e)
        {
            production_plan_fact_teamA.TextChanged += Production_plan_total_fact_TextChanged;
            production_plan_fact_teamB.TextChanged += Production_plan_total_fact_TextChanged;
            production_plan_fact_Sulf.TextChanged += Production_plan_total_fact_TextChanged;
        }
        private void Production_plan_total_fact_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(production_plan_fact_teamA.Text, out int production_plan_fact_teamA_value);
            int.TryParse(production_plan_fact_teamB.Text, out int production_plan_fact_teamB_value);
            int.TryParse(production_plan_fact_Sulf.Text, out int production_plan_fact_Sulf_value);
            long sum = (long)production_plan_fact_teamA_value + production_plan_fact_teamB_value + production_plan_fact_Sulf_value;
            production_plan_total_fact.Text = sum.ToString();
        }
        private void Oee_textChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string selectedText = textBox.Text;

            if (!string.IsNullOrEmpty(selectedText))
            {
                if (float.TryParse(selectedText, out float selectedValue))
                {
                    if (selectedValue >= 95.9)
                    {
                        // Закрашиваем ячейку в красный, если выбрано 0
                        textBox.Background = Brushes.LightGreen;
                    }
                    else
                    {
                        // Закрашиваем ячейку в зеленый, если выбрано число больше 0
                        textBox.Background = Brushes.LightCoral;
                    }
                }
                else
                {
                    // Восстанавливаем стандартный фон, если введено некорректное значение
                    textBox.Background = Brushes.White;
                }
            }
            else
            {
                // Очищаем фон, если не выбрано значение
                textBox.Background = Brushes.White;
            }

            //    TextBox textBox = (TextBox)sender;
            //    string selectedText = oee_inn1_teamA.Text;
            //    float Oee_teamA = float.Parse(oee_teamA.Text);
            //    float Oee_inn1_teamA = float.Parse(oee_inn1_teamA.Text);
            //    float Oee_inn2_teamA = float.Parse(oee_inn2_teamA.Text);
            //    float Oee_inn3_teamA = float.Parse(oee_inn3_teamA.Text);
            //    float Oee_uva4_teamA = float.Parse(oee_uva4_teamA.Text);
            //    float Oee_uva5_teamA = float.Parse(oee_uva5_teamA.Text);
            //    float Oee_acma_teamA = float.Parse(oee_acma_teamA.Text);
            //    if (!string.IsNullOrEmpty(selectedText))
            //    {

            //        try
            //        {

            //            if (Oee_teamA > 95)
            //            {
            //                oee_teamA.Background = Brushes.LightGreen;
            //            }
            //            else { oee_teamA.Background = Brushes.LightCoral; }
            //            if (Oee_inn1_teamA > 91)
            //            {
            //                oee_inn1_teamA.Background = Brushes.LightGreen;
            //            }
            //            else { oee_inn1_teamA.Background = Brushes.LightCoral; }
            //            if (Oee_inn2_teamA > 91.5)
            //            {
            //                oee_inn2_teamA.Background = Brushes.LightGreen;
            //            }
            //            else { oee_inn2_teamA.Background = Brushes.LightCoral; }
            //            if (Oee_inn3_teamA > 91.7)
            //            {
            //                oee_inn3_teamA.Background = Brushes.LightGreen;
            //            }
            //            else { oee_inn3_teamA.Background = Brushes.LightCoral; }
            //            if (Oee_uva4_teamA > 89.5)
            //            {
            //                oee_uva4_teamA.Background = Brushes.LightGreen;
            //            }
            //            else { oee_uva4_teamA.Background = Brushes.LightCoral; }
            //            if (Oee_uva5_teamA > 93.2)
            //            {
            //                oee_uva5_teamA.Background = Brushes.LightGreen;
            //            }
            //            else { oee_uva5_teamA.Background = Brushes.LightCoral; }
            //            if (Oee_acma_teamA > 86)
            //            {
            //                oee_acma_teamA.Background = Brushes.LightGreen;
            //            }
            //            else { oee_acma_teamA.Background = Brushes.LightCoral; }
            //        }
            //        catch (Exception ex)
            //        {
            //            downTray.Content = ex.Message;
            //        }
            //    }
        }
    }
}
