Feature: LolafloraLoginScreen
	Lolaflora.com kullanıcısının login sayfasında 
	ilgili girişler yaptıktan sonra sonuca ulaşmasını sağlar.


Scenario: LoginScreenUnregisteredUser
	* 'https://www.lolaflora.com/login' sayfasına girilir
	* E-Mail kutucuğuna 'yanliskullanici@gmail.com' girişi yapılır
	* Şifre kutucuğuna 'yanlis123' girişi yapılır
	* Sign In butonuna tıklanır
	* 'E-mail address or password is incorrect. Please check your information and try again.' uyarısı görülür
	* Uyarı penceresi kapatılır



Scenario: LoginSuccessfulUserLogin
	* 'https://www.lolaflora.com/login' sayfasına girilir
	* E-Mail kutucuğuna 'dogrukullanici@gmail.com' girişi yapılır
	* Şifre kutucuğuna 'dogrusifre' girişi yapılır
	* Sign In butonuna tıklanır
	* 'https://www.lolaflora.com/' sayfası kontrol edilir
	* Popup kapatılır
	* Sign Out butonuna tıklanır



Scenario: LoginScreenInvalidPassword
	* 'https://www.lolaflora.com/login' sayfasına girilir
	* E-Mail kutucuğuna 'yanliskullanici@gmail.com' girişi yapılır
	* Şifre kutucuğuna '1' girişi yapılır
	* Sign In butonuna tıklanır
	* Password için 'Please enter minimum 3 and maximum 20 characters.' uyarısı görülür


Scenario: LoginScreenInvalidPasswordOther
	* 'https://www.lolaflora.com/login' sayfasına girilir
	* E-Mail kutucuğuna 'yanliskullanici@gmail.com' girişi yapılır
	* Şifre kutucuğuna '123456789123456789123' girişi yapılır
	* Sign In butonuna tıklanır
	* Password için 'Please enter minimum 3 and maximum 20 characters.' uyarısı görülür


Scenario: LoginScreenInvalidEmail
	* 'https://www.lolaflora.com/login' sayfasına girilir
	* E-Mail kutucuğuna ' ' girişi yapılır
	* Şifre kutucuğuna '1234567' girişi yapılır
	* Sign In butonuna tıklanır
	* Email için 'Required field.' uyarısı görülür


Scenario: LoginScreenForgotPassword
	* 'https://www.lolaflora.com/login' sayfasına girilir
	* Forgot Password butonuna tıklanır
	* Mail kutucuğuna 'cicek@sepeti.com' girişi yapılır
	* Send butonuna tıklanır
	* Forgot Password için 'You will receive an e-mail from us with instructions for resetting your password.' uyarısı görülür