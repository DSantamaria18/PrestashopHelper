# PrestashopHelper
Util to bulk import attachments to prestashop site. 

INPUT FIELDS:

Attachments: Folder with the files to be associated to the products. Must be named with the product code to be associated with
Product CSV File: File with a list of product codes. It can be taken from the Prestashop database.
File Title: The name of the the file to be shown in PS.
Description: String whith the description for ALL the attachments. 
Output Dir: Folder where the result will be stored. 

OUTPUT:

ps_attachment.csv: File to be imported in the Prestashop PS_ATTACHMENT table. It contains attachments data. The remote path is forced to be your Prestashop UPLOAD folder. This will be configurable in future revisions... The 
ps_attachmen_lang.csv: File to be imported in the Prestashop PS_ATTACHMENT_LANG table. It contains the files' names and descriptions for the default lenguage configured in the site.
ps_product_attachment.csv: File to be imported in the Prestashop PS_PRODUCT_ATTACHMENT table. It contains the association between products and attachments

NOTE: Prior to import the result files, you must upload the files to the Prestashop's UPLOAD folder.
