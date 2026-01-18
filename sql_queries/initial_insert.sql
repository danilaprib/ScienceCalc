--INSERT INTO articles (title, content) VALUES ('All about starting with Arduino', 'First you need to define the scope of your project and choose which board you would need for it. After that...');
--INSERT INTO subjects (subject_name) VALUES ('Electronics');
INSERT INTO articles_to_subjects_bridge (article_id, subject_id) VALUES (3,3);

select * from articles;

ALTER TABLE articles_to_subjects_bridge
RENAME TO articles_to_subjects_bridges;