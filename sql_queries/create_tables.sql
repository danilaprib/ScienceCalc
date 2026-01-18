--DROP TABLE IF EXISTS subjects;
--DROP TABLE IF EXISTS articles;
--DROP TABLE IF EXISTS articles_to_subjects_bridge
CREATE TABLE subjects
(
	id BIGSERIAL PRIMARY KEY NOT NULL,
	name TEXT UNIQUE NOT NULL
);



CREATE TABLE articles
(
	id BIGSERIAL PRIMARY KEY NOT NULL,
	content TEXT NOT NULL,
	title TEXT NOT NULL,
	created_at TIMESTAMPTZ NOT NULL DEFAULT now()
);

CREATE TABLE articles_to_subjects_bridge
(
	subject_id BIGINT NOT NULL,
	article_id BIGINT NOT NULL,
	
	PRIMARY KEY (subject_id, article_id),

	CONSTRAINT fk_subject
        FOREIGN KEY (subject_id)
        REFERENCES subjects(id)
        ON DELETE CASCADE,

    CONSTRAINT fk_article
        FOREIGN KEY (article_id)
        REFERENCES articles(id)
        ON DELETE CASCADE
);