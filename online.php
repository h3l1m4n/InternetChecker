<?php
$type = $_GET['Type'];

if($type == "update")
{
date_default_timezone_set("Europe/Stockholm");  


$file = fopen("time.txt","w");
fwrite($file,date("YmdHis"));
fclose($file);


}
if($type == "mail")
{
$to      = 'TO@FOO.com';
$subject = 'Server Down';
$message = 'Server Down!!!!!!';
$headers = 'From: FROM@FOO.se' . "\r\n" .
    'Reply-To: FROM@FROM.se' . "\r\n" .
    'X-Mailer: PHP/' . phpversion();

mail($to, $subject, $message, $headers);
	
	
}
if($type == 'time')
{

	$f = fopen("time.txt", "r");

	// Read line from the text file and write the contents to the client
	echo fgets($f); 

	fclose($f);
	
}
?>
